

https://github.com/user-attachments/assets/dfc232eb-2631-4158-b04a-b0f80f3965b4

Also, note that - by colliding with the walls at high x/z velocity, the physics bumps the ball up from the plane - hence why the debugger output shows that it is off the ball momentarily.

The output debugger does not sync with real-time collision and the update method per frame, but it properly detects where the Jump (Spacebar button) is pressed at that frame.
