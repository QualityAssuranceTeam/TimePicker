Test Suite: TimePicker
======================
**TODO:**
* Check on different supported browsers and devices.
* Check for both RTL and LTR languages.

Referrences:
------------
* [TimePicker API](https://openui5.hana.ondemand.com/#docs/api/symbols/sap.m.TimePicker.html "Link to API documentation")
* [Test Environment](https://openui5.hana.ondemand.com/explored.html#/sample/sap.m.sample.TimePicker/preview "Link to the preview")
* [TimePicker.view.xml](https://openui5.hana.ondemand.com/explored.html#/sample/sap.m.sample.TimePicker/code/TimePicker.view.xml "Source code")
* [TimePicker.controller.js](https://openui5.hana.ondemand.com/explored.html#/sample/sap.m.sample.TimePicker/code/TimePicker.controller.js "Source code")

**TC1:**
Set time using clock icon and Save  
**Note:**
Repeat this test on all test timepickers (TP1 - TP4)

1. Click on the clock icon.
2. Set timers using mouse, keyboard or touch.
3. Press Ok.

**Expected:**  
Time is set correctly and change event is fired.  
Example change event: ```Change - Event 1: TimePicker __xmlview3--TP1:20:15```

**TC2:**
Set time using clock icon and Cancel   
**Note:**
Repeat this test on all test timepickers (TP1 - TP4)

1. Click on the clock icon.
2. Set timers using mouse, keyboard or touch.
3. Press Cancel.

**Expected:**  
Time is not set and there is no change event fired.  

**TC3:**
Set time using the text input with valid data.  
**Note:**
Repeat this test on all test timepickers (TP1 - TP4)

1. Click on the text input field.
2. Enter some valid data (example: ```00:00:00 AM```).
3. Click outside the field.

**Expected:**  
Time is set correctly and change event is fired.

**TC4:**
Set time using the text input field with invalid data for hours (12 and 24 hour format).

1. Click on input field of timer TP1 or TP2.
2. For the HH value try to enter value bigger than 23.
3. Try to enter any symbol that is not a digit (example: ```,.;?-+=!@#$%^&*``` and others).
4. Click on input field of timer TP3 or TP4.
5. For the hh value try to set value bigger than 12 or smaller than 01.
6. Try to enter any symbol that is not a digit (example: ```,.;?-+=!@#$%^&*``` and others).

**Expected:**  
TimePicker doesn't allow you to enter such values.

**TC5:**
Set time using the text input field with invalid data for minutes and seconds
**Note:** 
Repeat this test on all test timepickers (TP1 - TP4)

1. Click on the text input field.
2. For the mm and ss values try to set value bigger than 59.
3. Try to enter any symbol that is not a digit (example: ```,.;?-+=!@#$%^&*``` and others).

**Expected:**  
TimePicker doesn't allow you to enter such values.

**TC6:**
Set time using the text input field with invalid data for part of the day (AM/PM).

1. Click on the input field of TP3 and enter valid 12-hour format time (example: ```12:00 --```).
2. For the part of the day value try to enter letters different than AM and PM.
3. Try to enter any symbol that is not a letter (example: ```,.;?-+=!@#$%^&*123``` and others).

**Expected:**
TimePicker doesn't allow you to enter such values for AM and PM.

**TC7:**
Check prepopulated and default values.

1. Check the current time on the client machine.
2. Refresh the Sample:TimePicker page.
3. Check if TP3 is prepopulated with the current time of the client side.
4. Check if TP1 is initially populated with the default value set in the view.xml(```value="19:15"```).

**Expected:**
TP3 is initially prepopulated with the current time.  
TP1 is initially prepopulated with the default value set in the view.xml.  
There is no change event fired for that.

**TC8:**
Check placeholders.

1. Click on TP1, delete the default value and click outside the box.
2. The placeholder set in the view.xml appears in the input field of TP1 (```placeholder="Enter meeting start time"```).
3. Check that TP2 displays the placeholder set in the view.xml (```placeholder="Enter meeting end time"```).
4. Click on TP3, delete the default value and click outside the box.
5. The placeholder set in the view.xml appears in the input field of TP3 (```placeholder="Enter daily task deadline"```).
6. Check that TP4 displays the placeholder set in the view.xml (```placeholder="Enter time"```).

**Expected:**  
The correct placeholders are displayed in the input fields.

**TC9:**
Check time format.

1. Click on TP1 and delete the default value.
2. Check that the correct time format pattern is displayed (```'--:--'``` for ```valueFormat="HH:mm"```).
3. Click on TP2 and check that the correct time format pattern is displayed (```'--:--:--'``` for ```valueFormat="HH:mm:ss"```).
4. Click on TP3 and delete the prepopulated value.
5. Check that the correct time format pattern is displayed (```'--:-- --'``` for ```valueFormat="hh:mm a"```).
6. Clcik on TP4 and check that the correct time format pattern is displayed (```'--:--:-- --'``` for ```valueFormat="hh:mm:ss a"```).

**Expected:**  
The correct time format pattern is displayed in the input field while entering data.

**TC10:**
Check localized time picker.

1. Refresh the Sample:TimePicker page.
2. Click on the clock icon of TP1.
3. Check that the timepicker is set to the default value of that field (```value="19:15"```).
4. Click on the clock icon of TP2 or TP4.
5. Check that the timepicker is set to the current time of the client machine.
6. Click on the clock icon of TP3.
7. Check that the timepicker is set to the time taken at the initial page load (on step 1).

**Expected:**  
Time picker gadget is set to the time entered in the input field otherwise takes the current time.
