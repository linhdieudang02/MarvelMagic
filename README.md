# Marvel Magic VR: Hand-Tracked Visual Effects for Meta Quest

This Unity project implements a real-time, gesture-based visual effect system for Meta Quest using Unity’s Visual Effect Graph, Meta's All-in-One SDK, and OpenXR hand tracking. Inspired by superhero-style “magic casting,” the project features a glowing orb effect that attaches to the user’s hand, tracks its movement, and spawns ambient particle systems in VR without using post-processing.

## Features
- Stylized VFX orb that follows hand position
- Hand mesh-based particle spawning using SkinnedMeshRenderer
- Compatible with Meta Quest (tested on Quest 3)
- Uses additive HDR glow for performance-friendly visual effects
- Modular and extensible VFX Graph structure
- Integrated testing environment with spatial VR room

### Other prototype features
- Interactable cube
- 2 scripts 
- 1 VFX_hand_charged graph

## Tech
- Unity 6.00.0
- Meta XR All-in-One SDK
- OpenXR Plugin
- Visual Effect Graph (URP)
