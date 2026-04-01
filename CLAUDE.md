# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Repository Overview

This is an archive repository for an NTNU (Norwegian University of Science and Technology) Master's semester project on Immersive Technologies. The project focused on creating VR/AR applications to study bat behavior in different lighting conditions and their effects on echolocation and navigation.

**Important Note**: This repository contains only documentation artifacts (PDF report, video demonstrations). The actual Unity source code, C# scripts, and project assets are not stored in this repository.

## Contents

- `Report-Assignment-3.pdf` - Academic report documenting the project (10 pages, ~716KB)
- `Video-Assignment-3.mp4` - Video demonstration (~15MB)
- `Video-Assignment-3-VR.mp4` - VR-specific video demonstration (~14MB)
- `Readme.md` - Basic project description

## Original Project Technologies

The original project was built using:
- **Unity** - Game engine for VR/AR development
- **C#** - Programming language for Unity scripts
- **Oculus Integration** - SDK for VR headset integration

## Working with This Repository

### PDF Report Analysis
To extract information from the academic report:
```bash
# If pdftotext is available
pdftotext Report-Assignment-3.pdf output.txt

# Or using Python
python3 -c "import fitz; print(fitz.open('Report-Assignment-3.pdf')[0].get_text())"
```

### Video Files
The MP4 files contain project demonstrations. They can be viewed with standard media players or processed with FFmpeg if needed:
```bash
# Get video metadata
ffprobe -v error -show_format -show_streams Video-Assignment-3.mp4

# Extract frames for analysis
ffmpeg -i Video-Assignment-3.mp4 -vf "fps=1" frames/frame_%03d.png
```

### Potential Enhancements
If extending this project, typical additions would include:
- Unity project files (Assets/, ProjectSettings/, Packages/)
- C# scripts for bat behavior simulation
- Shader files for lighting/echo visualization
- 3D models and assets
- Build configurations

## Repository Structure

```
Immersive-Technologies/
├── CLAUDE.md                      # This file
├── Readme.md                      # Project description
├── Report-Assignment-3.pdf        # Academic documentation
├── Video-Assignment-3.mp4         # Standard video demo
├── Video-Assignment-3-VR.mp4     # VR-specific video demo
└── .vscode/
    └── settings.json              # VS Code Peacock theme settings
```

## Context for Future Development

If the Unity source code is located elsewhere or needs to be added:
1. The project targets VR platforms (Oculus)
2. Focus area: Bat echolocation and navigation behaviors
3. Key feature: Variable lighting conditions simulation
4. Academic context: Master's level ICT-Simulation and Visualization course at NTNU
