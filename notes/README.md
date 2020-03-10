# Notes

## Objectives

> The aim of this project is to realise the advanced feature of simultaneously teleport objects from different locations. The main challenge is to correctly interpret the frames received from the various clients in order to avoid poor QoE due to the overlapping frames and to maintain low complexity and processing times.

* Allow display of multiple sources simultaneously
    - Serverside OpenGL display, Mobile AR
    - Additionally allow independent movement, rotation etc
* Extend network capabilities of suite to allow the ***efficient*** collation of frames from multiple sources for delivery to UE
* Employ network behaviours that mitigate higher bandwidth requirements

## Significance

## Challenges

* Synchronising clients
    - Important - When sources temporally coherent, multiple band locations etc
    - Not important - Sources are completely independent 
* Bandwidth
    - *n* sources **could** use *n* times as much bandwidth
    - Compression?
    - Stream only bodies?
    - Multiple TCP connections
* Shift in experience paradigm
    - Not one connection to one source but a session to view multiple streams
    - Could change behaviour with poor network conditions
* Identification of clients and sources (handshake)

##  Mid-Year Feedback

* Link citations better
* Intro - add objectives
* Future works - Gantt Chart?
* Writing style
* Motivation, technical challenges/targets
* Relate technical details/achievements to state of field