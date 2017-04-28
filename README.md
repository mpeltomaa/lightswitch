# Lightswitch #

Simple lightswitch code to toggle lights on / off. Current version supports only one type of lightswitch. Click sound is from http://soundbible.com/1705-Click2.html


### Changelist: ###

1.1: Proper lightbulb. Divided to two example scenes. Lightswitch code supports emissive materials

1.0: Initial release

#### Basic use, simple lights (Scene: Example_1_Bulb_without_emission) ####
In this example scene you can find *LightSwitch* object, inside *LightSwitch* is *Switch*. Lightswitch code is attached to *Switch*. When you click switch
code will go thru all lights on gameobjects assigned to Lights array on code.


#### Lights with emissive material (Scene: Example_2_Bulb_with_emission) ####
This example is same as above added with material emission change. On *Switch* you can see two options:

- Use emissive materials (true / false)
- Default emissive material

If *Use emissive materials* is checked code will go thru lights and toggle emission on / off on selected material.
