# Obsidian Chronology Plugin

Provides a sidebar with a calendar view of your notes.

![](https://raw.githubusercontent.com/Canna71/obsidian-chronology/master/media/demo.gif)

The calendar allow to navingate and select a daily, weekly, monthly or custom range of notes. Daily and Weekly range are displayed in a time line but you can force the display of the notes in a simple list by enabline the setting `Display Simple List`.
In the timeline visualization, you can group notes that were created or modified in the same time slot by enabling `Group Notes in same time slot`.

Click the month name to see a list of all notes of that month.

To select a range of dates to display: select one date than shift-click the other date of the range.

The notes in the timeline will be shown with a colored marked indicating if they were **created** or **modified** at that moment.


![](https://raw.githubusercontent.com/Canna71/obsidian-chronology/master/media/example.png)


Clicking on the name of the note will open it. Ctrl-(or Command-) clicking the note name will open it in a new pane.

In the calendar you can select the single days or the week number (on the left).

The days tiles background gives an indication about how many notes were created or edited that day. The scale depends also on the average number of daily notes set in the settings.

# Obsidian Sync Issues
If you have Obsidian Sync, you might have noticed that synced file will have a creation timestamp corresponding to when they were synced to the other machines.
In version 1.1.9 a couple of settings were added in order to work around this issue by (optionally) reading from the file metadata the actual creation date of the note.
It is not mandatory that every note has a creation/modification date in the metadata, if it is missing the plugin will fallback to the file creation or modification date.
