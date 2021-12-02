# GenshinAR
Mobile app using AR for displaying and using Genshin models with animations

### APP is currently due in development, this is a demo preview as I need to prepare more models and functionality into it

## How to use?

The software works only on Android devices and may work on PC with a camera.

- First we need to target a plane ground for our camera and then tap the screen whenever the square indicator pops
![](https://user-images.githubusercontent.com/49035865/144503581-938dc246-b38b-464a-ab9d-c0c369a839be.jpg)
- Next after setting the ground plane choose the character you want to display
![](https://user-images.githubusercontent.com/49035865/144503913-7a5bc553-3da3-4e2b-b691-f8b668dfb18d.jpg)
- Now when the character is displayed you can freely rotate it and scale it within basic smarthphone gestures (sliding left and right and pinching it). To play the animations simply press one of the buttons and if you want to stop it or activate the next one you need to press Stop button which gonna reset our character transform.position and transform.rotation
![](https://user-images.githubusercontent.com/49035865/144504362-f5a67862-679f-4f14-a3d3-1ed6907abc60.jpg)

## External libraries and models:

### Vuforia 10.2.5
- [Download](https://developer.vuforia.com/downloads/sdk)

### Genshin Impact models were downloaded from there:
- [Liyue Models](https://ys.biligame.com/ysl/)
- [Liyue Models 2](http://ys.biligame.com/pjdkx/)
- [Dodoko event Models](https://www.bilibili.com/blackboard/activity-kiOl0D1nF8.html)
- [Mondstadt Models](https://ys.biligame.com/gczj/)
- [More Models](https://genshin.mihoyo.com/ja/news/detail/5885)

All of these are free for use .pmx models made mainly for Japanese community which are mainly made for MMD (MikuMikuDance) video game.

*Unfortunately .pmx/.mmd models can't work within Unity environment so I had to use these great plugins for blender so I could easily extract bones and models themselves 
into .fbx format. Thank you so much for these golden masterwork!*

### Cats Blender Plugin 
- [Github Link](https://github.com/absolute-quantum/cats-blender-plugin/blob/master/README.md)

### mmd_tools
- [Github Link](https://github.com/powroupi/blender_mmd_tools)

### Animations are from *Mixamo*
- [Link](https://www.mixamo.com/)

## TODO in future
- Upgrading the interface
- Adding new models
- New Animations
- Aspect of gamification (levels, currency, unlockables)

Initially it was supposed to be a birthday gift, but unfortunately the person for who this app was made has a smartphone without AR support. [*]
