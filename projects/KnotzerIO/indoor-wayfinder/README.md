> [!TIP]
> Looking for a more advanced indoor navigation solution?
> Try [OpenIndoorMaps](https://github.com/openindoormap/openindoormaps) - featuring map editing, 3D views, and outdoor map integration.

# Pathpal: Web-Based Indoor Wayfinder

Pathpal is an innovative web application designed to revolutionize indoor navigation. Using interactive maps and efficient pathfinding algorithms, it offers an intuitive solution for navigating complex indoor spaces.
<br>
**Demo:** [Visit Pathpal](https://indoor-wayfinder.vercel.app)

## Table of Content:

- [Pathpal: Web-Based Indoor Wayfinder](#pathpal-web-based-indoor-wayfinder)
  - [Table of Content:](#table-of-content)
  - [About The App](#about-the-app)
  - [Screenshots](#screenshots)
  - [Features](#features)
  - [Technologies](#technologies)
  - [Setup](#setup)
  - [Technical Insights](#technical-insights)
    - [Map Technology](#map-technology)
    - [Pathfinding](#pathfinding)
    - [Core Map Technology](#core-map-technology)
    - [Path Drawing and Wayfinding](#path-drawing-and-wayfinding)
    - [Customizing the Map](#customizing-the-map)
  - [Credits](#credits)
  - [License](#license)

## About The App

This project is a variation of my diploma project, focusing on an interactive map for indoor wayfinding and navigation. It features an interactive SVG map and utilizes the Dijkstra algorithm to calculate the shortest path to points of interest (POIs). Originally, the application experimented with indoor positioning using BLE technology, but due to ithe experimental nature of the Bluetooth Web API, it has been omitted in this variation.

> [!WARNING]  
> The backend of this project has been removed. All data are stored in a JSON file. This project is a prototype and should not be used for production purposes. Please check out my new project [OpenIndoorMaps](https://github.com/yourusername/OpenIndoorMaps) for a more comprehensive solution.

## Screenshots

<table style="border-radius: 10px;  border: 1px solid gray;">
  <tr >
    <td align="center"><img src="https://raw.githubusercontent.com/KnotzerIO/indoor-wayfinder/main/media/indoor-map-details.png"/></td>
   <td align="center"><h3 >Displaying Object Information on Click</h3></td>
  </tr>
    <tr>
    <td align="center"><img src="https://raw.githubusercontent.com/KnotzerIO/indoor-wayfinder/main/media/indoor-wayfinding.png"/></td>
    <td align="center"><h3>Demonstration of Shortest Path Calculation</h3></td>
  </tr>
</table>

## Features

- **Interactive SVG Maps**: Navigate complex indoor spaces with ease.
- **Dijkstra Pathfinding**: Calculates the shortest path to your destination.
- **Responsive Design**: Optimized for any device and screen size.
- **Customizable POIs**: Edit names and categories of points of interest.
- **Pinch-to-Zoom**: Effortlessly zoom in and out on maps with touch gestures.

## Technologies

Pathpal is built with the latest web technologies for speed, efficiency, and adaptability:

- React
- Vite
- TypeScript
- TailwindCSS
- SVG
- Dijkstra's Algorithm

## Setup

Follow these steps to get the project up and running:

1. **Clone the Repository**: Use your preferred Git client to clone this repository to your local machine.

2. **Install Node.js**: This project requires Node.js. If you don't have Node.js version 21 installed, you can download and install it from [nodejs.org](https://nodejs.org/).

3. **Install Dependencies**: Navigate to the project directory in your terminal and run the following command to install the necessary dependencies:

   ```bash
   npm install
   ```

4. **Start the Application**: Once the dependencies are installed, you can start the application by running the following command in your terminal:

   ```bash
   npm run dev
   ```

After running these commands, your default web browser should automatically open and navigate to `localhost:5173`, where you can see the running application.

## Technical Insights

### Map Technology

- **SVG Format**: The map is primarily SVG for its flexibility and interactive capabilities, ideal for detailed navigation.
- **Image Format Support**: Supports various formats like PNG and JPEG for map backgrounds, with interactive features best suited for SVG.

### Pathfinding

- **Routes Definition**: Paths within the map represent navigable routes, essential for the Dijkstra algorithm to calculate efficient paths.
- **Dijkstra Algorithm**: Ensures accurate and swift navigation between POIs.

### Core Map Technology

- **SVG as the Default Format**: The application primarily uses an SVG (Scalable Vector Graphics) file for the map due to its scalability and ease of manipulation. SVGs allow for interactive and dynamic rendering of indoor spaces, making them ideal for detailed navigation paths.
- **Support for Various Image Formats**: While SVG is the default, the system is designed to accommodate any image format (e.g., PNG, JPEG) as a map background. This flexibility ensures that developers can use existing floor plans or maps without needing to convert them to SVG. However, the primary interactive and navigational features are optimized for SVG.

### Path Drawing and Wayfinding

- **Path Drawing**: For navigation to function, paths must be defined within the map. These paths represent walkable routes and are crucial for the wayfinding algorithm. In SVG files, paths can be drawn and edited directly, allowing for precise control over navigation routes.
- **Wayfinding Algorithm**: The application utilizes the Dijkstra algorithm for calculating the shortest path between points of interest (POIs) on the map. This algorithm operates on the network of paths drawn on the map, ensuring efficient and accurate navigation.

### Customizing the Map

- **Editing Tools**: Developers have the option to utilize vector graphic editing tools such as Adobe Illustrator or Boxy SVG for modifying the SVG map. This modification can involve updating layouts, adding or removing Points of Interest (POIs), and adjusting paths. Refer to the screenshot below to see an example of map editing using Boxy SVG. For converting SVG to JSX, [Transform Tools](https://transform.tools/) can be a useful resource.

![IndoorMap Editing Example](https://raw.githubusercontent.com/KnotzerIO/indoor-wayfinder/main/media/map-editing-preview.png)

## Credits

This project was inspired by my diploma work and significantly influenced by the support of mentors, peers, and resources like [maciejb2k's pathfinding app](https://github.com/maciejb2k/pathfinding_app).

## License

Pathpal is open-sourced under the MIT License. Contributions and feedback are welcome!
