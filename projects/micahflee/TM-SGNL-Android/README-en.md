# Signal Android

Signal is a simple, powerful, and secure messenger.

Signal uses your phone's data connection (WiFi/3G/4G/5G) to communicate securely. Millions of people use Signal every day for free and instantaneous communication anywhere in the world. Send and receive high-fidelity messages, participate in HD voice/video calls, and explore a growing set of new features that help you stay connected. Signal’s advanced privacy-preserving technology is always enabled, so you can focus on sharing the moments that matter with the people who matter to you.

Currently available on the Play Store and [signal.org](https://signal.org/android/apk/).

<a href='https://play.google.com/store/apps/details?id=org.tm.archive&pcampaignid=MKT-Other-global-all-co-prtnr-py-PartBadge-Mar2515-1'><img alt='Get it on Google Play' src='https://play.google.com/intl/en_us/badges/images/generic/en_badge_web_generic.png' height='80px'/></a>

## Contributing Bug reports
We use GitHub for bug tracking. Please search the existing issues for your bug and create a new one if the issue is not yet tracked!

https://github.com/signalapp/Signal-Android/issues

## Joining the Beta
Want to live life on the bleeding edge and help out with testing?

You can subscribe to Signal Android Beta releases here:
https://play.google.com/apps/testing/org.tm.archive

If you're interested in a life of peace and tranquility, stick with the standard releases.

## Contributing Code

If you're new to the Signal codebase, we recommend going through our issues and picking out a simple bug to fix (check the "easy" label in our issues) in order to get yourself familiar. Also please have a look at the [CONTRIBUTING.md](https://github.com/signalapp/Signal-Android/blob/main/CONTRIBUTING.md), that might answer some of your questions.

For larger changes and feature ideas, we ask that you propose it on the [unofficial Community Forum](https://community.signalusers.org) for a high-level discussion with the wider community before implementation.

## Contributing Ideas
Have something you want to say about Signal projects or want to be part of the conversation? Get involved in the [community forum](https://community.signalusers.org).

Help
====
## Support
For troubleshooting and questions, please visit our support center!

https://support.signal.org/

## Documentation
Looking for documentation? Check out the wiki!

https://github.com/signalapp/Signal-Android/wiki

# Legal things
## Cryptography Notice

This distribution includes cryptographic software. The country in which you currently reside may have restrictions on the import, possession, use, and/or re-export to another country, of encryption software.
BEFORE using any encryption software, please check your country's laws, regulations and policies concerning the import, possession, or use, and re-export of encryption software, to see if this is permitted.
See <http://www.wassenaar.org/> for more information.

The U.S. Government Department of Commerce, Bureau of Industry and Security (BIS), has classified this software as Export Commodity Control Number (ECCN) 5D002.C.1, which includes information security software using or performing cryptographic functions with asymmetric algorithms.
The form and manner of this distribution makes it eligible for export under the License Exception ENC Technology Software Unrestricted (TSU) exception (see the BIS Export Administration Regulations, Section 740.13) for both object code and source code.

## License

Copyright 2013-2024 Signal Messenger, LLC

Licensed under the GNU AGPLv3: https://www.gnu.org/licenses/agpl-3.0.html

Google Play and the Google Play logo are trademarks of Google LLC.


//**TM_SA**//
Signal – New Base-line
1.	Download the Signal official open source from this link:
      https://github.com/signalapp/Signal-Android

2.	Rename each folder at the next order:
      a.	thoughtcrime  tm
      b.	securesms  archive
3.	Replace all old package mentions vie “replace all” function (Ctrl +Shift + R)
      a.	org.tm.archive -> org.tm.archive
4.	Add our archiver SDK and Common library to new folder “libs” and compile them via dependencies.
5.	Add archiver,intune,selfauthentication folders with all archiving class with util etc. (Take them from src->main->java->org)
6.	Search “ArchiveLogger.Companion.sendArchiveLog” in the current project and add all those mentions to the updated project.
7.	Add launcher icon app and change the round icon path in the manifest
8.	Add proguard-event_bus from the current project to the updated one.
9.	Go to the current TeleMessage Signal project and search via ctrl+alt+F : //**TM_SA**//

There are dozens of references to this string please move on the result one by one and replace or add the code with this string ( //**TM_SA**//, in order to create continuation to baseline updating method)


intune

1. add dependencies using //**TM_SA**//
2. add MAMSDK folder with aar and jar
3. 1. register the app to intune server
2. https://aad.portal.azure.com/#view/Microsoft_AAD_IAM/ActiveDirectoryMenuBlade/~/Overview3. Azure Active Directory > App registrations > New Registration
3. Authentication, add platform -> add uri -> package name.
4. then add auth-config file using the View button that show it. put it in resource-> raw
5. API permissions...

4. 1. https://aad.portal.azure.com/#view/Microsoft_AAD_IAM/ActiveDirectoryMenuBlade/~/RegisteredApps
2. then, App configuration policies -> create app configuration policy -> manage apps -> Settings -> add the values(managerID etc)
3. Then, Assignments -> include groups you want or assign everyone.

5. http://everythingaboutintune.com/2021/07/guide-for-integrating-intune-sdk-and-msal-to-lob-application/

https://www.youtube.com/watch?v=1AyGpcdDRkY&t=741s&ab_channel=EverythingAboutIntune
https://github.com/msintuneappsdk/Taskr-Sample-Intune-Android-App#readme
//**TM_SA**//


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---