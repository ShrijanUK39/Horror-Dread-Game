using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Spawn holes in the floor of the maze
public class Coordinates
{

    public Coordinates()
    {
        x = 0;
        y = 0;
        z = 0;
    }
    public Coordinates(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public int x;
    public int y;
    public int z;

    public void set(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

}