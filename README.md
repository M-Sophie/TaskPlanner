# TaskPlanner

For a clearer picture, you will find a nicely-formatted Google Docs version here with screenshots: https://docs.google.com/document/d/1uuMYKCoicTdUvQP23R6oVOygWogSZ8a9eP5CqTBRT1g/edit?usp=sharing 

Program walkthrough

This program holds two Windows Forms.
1- The first is called MainForm. It opens when the program starts. 
It contains the following elements:
General menu strip, containing
	Copy (Ctrl + C), not yet implemented but would allow copying a task
	Paste (Ctrl + V), not yet implemented but would allow pasting of a copied task
	Cut (Ctrl + X), not yet implemented but would allow copying and deleting a task
	Undo (Ctrl + Z), not yet implemented but would allow undoing the last action(s)
File menu strip, containing
	Save (Ctrl + S), not yet implemented but would allow saving a list
	New (Ctrl + N), . which opens a new MainForm, which is blank, for a new list
	Export as SVG (Ctrl + P), not yet implemented but would allow saving a list as SVG
	Close (Ctrl + Q), which closes the program without saving
A blank space, which will be filled with up to 10 tasks as they are added by the user. These tasks hold a box on their right, which can be selected for deletion (and, eventually, for viewing)
Clear button (Alt + C), which removes all tasks from view and allows for a fresh start
Delete button (Alt + D), which removes all selected tasks, leaving a blank space in its place, which can be refilled with a new task
View button (Alt + V), which is not currently abled, but would allow to view and modify the details of a selected task once implemented
Add button (Alt + A), which is discussed below. Note that, once the screen is full (10 tasks are displayed), a MessageBox will be displayed and the following NewTask Windows Form will not open

2- The second is called NewTask. It opens when the user selects the Add button. 
It contains the following elements:
Textbox on the righthand side of the word “Task”, which can be filled by the user
Save button (Alt + S), which will save the entered text as a new task, if not blank, and open a MessageBox to confirm successful saving before closing the NewTask window and reopening the MainForm one
Cancel button (Alt + C), which will close the NewTask window and reopening the MainForm one


Bugs and known issues

The program does not support saving and recovery
The program does not support exporting as an SVG
The program does not support Undo
The program does not support Copy, Paste, or Cut


To do

Save and recover
Export as SVG
Undo button
Copy button
Paste button
Cut button
View Button
