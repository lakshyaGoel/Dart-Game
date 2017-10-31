Project by
===========
Ayushi Srivastava \| Lakshya Goel
----------------------------------
**Course Details**\
CSCI 5619 \| Virtual Reality \| Fall 2017 \| UMN

Overview
========

Virtual Reality is largely about giving someone life-like experiences
living a different reality.\
We aim to develop a dart game with simulated darts & dartboard so one
could satisfy a dart-game craving by just downloading our game!

Goals
=====

1.  To capture hand-motion by Leap Motion Tracking

2.  Simulate a stationary dartboard and a freely-movable dart

3.  Correlate (1) & (2) to make a darts-game

Technology Specifications
=========================

Hand Tracking
---------------------------

**Hardware** **:** Leap Motion\
**Software :** C\# / Python to transfer Leap Motion 'Frames' containing data to Unity

Dart Movement and Dartboard simulation
---------------------------
**Hardware :** This simulation shall be realised with a Head-Mounted VR device tested on HTC Vive.\
**Software :** Unity, which simulates the dart, board, and based on the values received from Vive Controllers, will make the darts move.

Milestones
==========

Static Simulation & Tracking data transfer
------------------------------------------

> Herein the darts and dartboard are simulated, hand-tracking is
> completed and data gets transferred from the Leap Motion Device to
> Unity.

Game Logistics & Dynamic Simulation
-----------------------------------

> In this part, we ensure that the darts move as per the data
> transferred into Unity, this step would involve more game-specific
> characteristics and we will try to handle as many edge cases as
> possible
