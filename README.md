# Engima Machine
This project is a clean, modular recreation of the German Enigma Machine, designed to demonstrate how classical rotor‑based cryptography works. It simulates the full encryption workflow — rotors, plugboard, reflector, stepping mechanism — while keeping the codebase easy to read, extend, and test.

<img width="1388" height="622" alt="image" src="https://github.com/user-attachments/assets/39d424ee-0b12-47d8-a6b6-2b8160213348" />

# Features
- Full functional rotor system with configurable rotor order and accurate stepping and double-stepping behaviour
- Reflector simulation
- Plugboard support
- Character-by-character encryption
- Deterministic output
- Modular architecture for easy extension and experimentation
- Clear separateion of concerns

# How it works
The Enigma Machine encrypts text through a sequence of transformations:
- Plugboard swaps letters
- Rotors shift and map characters through internal wiring
- Reflector bounces the signal back
- Rotors apply the reverse mapping
- Plugboard swaps letters again
- Rightmost rotor steps (with double‑stepping logic)
This implementation follows the historical behaviour closely while keeping the code readable and maintainable.


