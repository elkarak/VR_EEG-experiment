## Description
This is a VR experiment integrated with EEG data collection. The project is designed to study user interactions in virtual reality while capturing real-time EEG data for analysis. This repository contains all the materials needed to reproduce the VR-EEG experiment pre-registered on OSF.

## Folder specification
In each task folder (Luminance and Symmetry) there are Straight and Angled folders, containing the tasks with the correct camera specifications for the specified folder Condition (Straight = Frontoparallel, Angled = Perspective). Each of the Condition folders contain a Main and Practice folder, the Main folder contains the critical task used in the Experiment, includes the code to send triggers to the Biosemi trigger box and the eyetracking calibration. Each Main folder has:

- `Assets/` - Contains Unity assets, scenes, scripts, and prefabs.
- `Docs/` - Documentation and setup guides.
- `Data/` - Collected EEG data and experiment results.
- `Library/` - Unity-specific cache files (ignored in Git).
- `ProjectSettings/` - Unity project settings.

### Prerequisites
- Unity 2021.3.x or newer.
- VR headset (HTC Vive Eye pro).
- EEG device (BIOSEMI).

## Installation
Some files exceed the github file size allowance, so the repository contains pointer files instead. To load these files please install git LFS before cloning the repository. 
1. Clone this repository:
   ```bash
   git clone https://github.com/elkarak/VR_EEG-experiment.git
