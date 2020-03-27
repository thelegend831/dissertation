# Notes

## Objectives

> The aim of this project is to realise the advanced feature of simultaneously teleport objects from different locations. The main challenge is to correctly interpret the frames received from the various clients in order to avoid poor QoE due to the overlapping frames and to maintain low complexity and processing times.

* Allow display of multiple sources simultaneously
    - Serverside OpenGL display, Mobile AR
    - Additionally allow independent movement, rotation etc
* Extend network capabilities of suite to allow the ***efficient*** collation of frames from multiple sources for delivery to UE
* Employ network behaviours that mitigate higher bandwidth requirements

## Significance

* Generic implementation
    - Flexible uses
    - Different to architecture example as users are not necessarily included in experience
        - Separation of viewer and session
        - Can just consume and not interact

## Challenges

* Synchronising clients
    - Important - When sources temporally coherent, multiple band locations etc
    - Not important - Sources are completely independent 
* Bandwidth
    - *n* sources **could** use *n* times as much bandwidth
    - Compression?
    - Stream only bodies?
    - Multiple TCP connections
    - Selective frame dropping? for research paper
* Shift in experience paradigm
    - Not one connection to one source but a session to view multiple streams
    - Could change behaviour with poor network conditions
    - Football red zone analogy
        - When a game stops or loses signal, this stream should be culled
* Identification of clients and sources (handshake)

## Testing Methodology

* Bandwidth measures
    - Base codebase vs my version
* FPS
* CPU measurements?
* Different source configurations
* Qualitative Measures?
    - User experience
        - Particular points of immersion/discomfort

## Questions

* How do I reference Ioannis' work?
* How do I describe the manor with which I "chose" LiveScan?
* How do I conduct testing?
    * FPS/Delay research?

##  Mid-Year Feedback

* Link citations better
* Intro - add objectives
* Future works - Gantt Chart?
* Writing style
* Motivation, technical challenges/targets
* Relate technical details/achievements to state of field