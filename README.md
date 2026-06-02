# PingPong_Unity_Project-Replica
**Unity 2D · November 2021**

A two-player Pong replica in Unity with configurable player names, rounds, score tracking, and a cooldown-based ball reset system.

## Features

- Two-player local multiplayer — each paddle mapped to a separate input axis
- Configurable player names via input fields, rounds via slider — set before match starts
- Ball launches in a pseudo-random direction on each reset
- Cooldown timer between rounds — countdown displayed on screen
- Score tracking per player — win detected when a player reaches the configured round limit
- Win screen with player name displayed, board resets for a new match

## Architecture

- `BallMovement` — handles launch direction, velocity, cooldown timer, goal trigger detection, score increment
- `PaddleMovement` — reads input axis, drives Rigidbody2D velocity, displays player name on board
- `GameDataManager` — reads setup UI (names, rounds slider), detects win condition, shows end screen
- `ScoreBoard` / `TextChanger` — UI display utilities

## Stack

Unity 2D · C# · Rigidbody2D · TMPro · Physics2D
