# ESP32-TWAI-CAN

ESP32 driver library for TWAI / CAN for Arduino using ESP-IDF drivers.

Tested on ESP32 and ESP32-S3.

# Usage

Library has everything inside it's header, just include that and then use `ESP32Can` object to send or receive `CanFrame`.


Here is simple example how to query and receive OBD2 PID frames:
```cpp
#include <ESP32-TWAI-CAN.hpp>

// Default for ESP32
#define CAN_TX 5
#define CAN_RX 4

CanFrame rxFrame;

void sendObdFrame(uint8_t obdId) {
    CanFrame obdFrame         = {0};
    obdFrame.identifier       = 0x7DF; // Default OBD2 address;
    obdFrame.extd             = 0;
    obdFrame.data_length_code = 8;
    obdFrame.data[0]          = 2;
    obdFrame.data[1]          = 1;
    obdFrame.data[2]          = obdId;
    obdFrame.data[3]          = 0xAA; // Best use 0xAA (0b10101010) instead of 0
    obdFrame.data[4]          = 0xAA; // TWAI / CAN works better this way, as it
    obdFrame.data[5]          = 0xAA; // needs to avoid bit-stuffing
    obdFrame.data[6]          = 0xAA;
    obdFrame.data[7]          = 0xAA;
    // Accepts both pointers and references
    ESP32Can.writeFrame(obdFrame); // timeout defaults to 1 ms
}

void setup() {
    // Setup serial for debbuging.
    Serial.begin(115200);

    // Set pins
    ESP32Can.setPins(CAN_TX, CAN_RX);

    // You can set custom size for the queues - those are default
    ESP32Can.setRxQueueSize(5);
    ESP32Can.setTxQueueSize(5);

    // .setSpeed() and .begin() functions require to use TwaiSpeed enum,
    // but you can easily convert it from numerical value using .convertSpeed()
    ESP32Can.setSpeed(ESP32Can.convertSpeed(500));

    // You can also just use .begin()..
    if(ESP32Can.begin()) {
        Serial.println("CAN bus started!");
    } else {
        Serial.println("CAN bus failed!");
    }

    // or override everything in one command;
    // It is also safe to use .begin() without .end() as it calls it internally
    if(ESP32Can.begin(ESP32Can.convertSpeed(500), CAN_TX, CAN_RX, 10, 10)) {
        Serial.println("CAN bus started!");
    } else {
        Serial.println("CAN bus failed!");
    }
}

void loop() {
    static uint32_t lastStamp    = 0;
    uint32_t        currentStamp = millis();

    if(currentStamp - lastStamp > 1000) { // sends OBD2 request every second
        lastStamp = currentStamp;
        sendObdFrame(5); // For coolant temperature
    }

    // You can set custom timeout, default is 1000
    if(ESP32Can.readFrame(rxFrame, 1000)) {
        // Comment out if too many frames
        Serial.printf("Received frame: %03X  \r\n", rxFrame.identifier);
        if(rxFrame.identifier == 0x7E8) {                                    // Standard OBD2 frame responce ID
            Serial.printf("Collant temp: %3d°C \r\n", rxFrame.data[3] - 40); // Convert to °C
        }
    }
}
```

# Advanced
You can also setup your own masks and configurations:

```cpp
// Everything is defaulted so you can just call .begin() or .begin(TwaiSpeed)
// Calling begin() to change speed works, it will disable current driver first
bool begin(TwaiSpeed twaiSpeed = TWAI_SPEED_500KBPS, 
           int8_t txPin = -1, int8_t rxPin = -1,
           uint16_t txQueue = 0xFFFF, uint16_t rxQueue = 0xFFFF,
           twai_filter_config_t*  fConfig = nullptr,
           twai_general_config_t* gConfig = nullptr,
           twai_timing_config_t*  tConfig = nullptr);
```

Follow `soc/twai_types.h` for more info:

```c
typedef struct {
    union {
        struct {
            //The order of these bits must match deprecated message flags for compatibility reasons
            uint32_t extd: 1;           /**< Extended Frame Format (29bit ID) */
            uint32_t rtr: 1;            /**< Message is a Remote Frame */
            uint32_t ss: 1;             /**< Transmit as a Single Shot Transmission. Unused for received. */
            uint32_t self: 1;           /**< Transmit as a Self Reception Request. Unused for received. */
            uint32_t dlc_non_comp: 1;   /**< Message's Data length code is larger than 8. This will break compliance with ISO 11898-1 */
            uint32_t reserved: 27;      /**< Reserved bits */
        };
        //Todo: Deprecate flags
        uint32_t flags;                 /**< Deprecated: Alternate way to set bits using message flags */
    };
    uint32_t identifier;                /**< 11 or 29 bit identifier */
    uint8_t data_length_code;           /**< Data length code */
    uint8_t data[TWAI_FRAME_MAX_DLC];    /**< Data bytes (not relevant in RTR frame) */
} twai_message_t;

/**
 * @brief   Structure for bit timing configuration of the TWAI driver
 *
 * @note    Macro initializers are available for this structure
 */
typedef struct {
    uint32_t brp;                   /**< Baudrate prescaler (i.e., APB clock divider). Any even number from 2 to 128 for ESP32, 2 to 32768 for ESP32S2.
                                         For ESP32 Rev 2 or later, multiples of 4 from 132 to 256 are also supported */
    uint8_t tseg_1;                 /**< Timing segment 1 (Number of time quanta, between 1 to 16) */
    uint8_t tseg_2;                 /**< Timing segment 2 (Number of time quanta, 1 to 8) */
    uint8_t sjw;                    /**< Synchronization Jump Width (Max time quanta jump for synchronize from 1 to 4) */
    bool triple_sampling;           /**< Enables triple sampling when the TWAI controller samples a bit */
} twai_timing_config_t;

/**
 * @brief   Structure for acceptance filter configuration of the TWAI driver (see documentation)
 *
 * @note    Macro initializers are available for this structure
 */
typedef struct {
    uint32_t acceptance_code;       /**< 32-bit acceptance code */
    uint32_t acceptance_mask;       /**< 32-bit acceptance mask */
    bool single_filter;             /**< Use Single Filter Mode (see documentation) */
} twai_filter_config_t;
```


