# Behavioural-Design-Pattern
# State-Design-Pattern
# Stopwatch-Functions

Console App For Stopwatch Functions Using State Design Pattern.

This stopwatch functions imitate how the display text on the buttons are changed based on the state. 
There are two buttons. What operations/actions done when the button is clicked is different and depending 
on the current state it is in. But here,I doesn't used real buttons. Instead, defined two string variable 
fields holding the display texts for the 1st and 2nd button.

For example, in the initial screen state, the string variable field for the 1st button is set to 
“Start”, and the string variable field for the 2nd button is set to “Lap”. After calling the method 
for clicking the 1st button (the 1st button is currently displaying the text as “Start”), it will 
move to the running state, and the string variable field for 1st button will be changed to “Stop”.
