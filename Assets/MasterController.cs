using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;   
using Valve.VR;
using System;



public class MasterController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.Button.Two))
        {
            //If press B then the object will release
            if(Pickuplight.pickedUp == true)
            {
                Pickuplight.pickedUp = false;
            }
        }
    }
}


// What is async?
// Async is a keyword in C# that is used to indicate that a method, property, or event is asynchronous. An asynchronous method is a method that returns before the called operation is complete.

// Now give me a test for this in C# to check my understanding of async and await

async void TestAsync()
{
    await Task.Run(() =>
    {
        // Do some work
    });
}


// The above code is a sudo code? 






if (Input.GetKeyDown(KeyCode.Space))
{
    TestAsync();
    else 
    {
        TestSync()->async;
    }
}













// What is await?
// Await is a keyword in C# that is used to indicate that a method, property, or event is asynchronous. An asynchronous method is a method that returns before the called operation is complete.

// What is a coroutine?
// A coroutine is a function that can be paused and resumed. Coroutines are used to perform operations that take a long time to complete, such as loading a file or waiting for a network response.

// What is a callback?
// A callback is a function that is called when a specific event occurs. Callbacks are used to perform operations that take a long time to complete, such as loading a file or waiting for a network response.

// What is a delegate?
// A delegate is a function pointer that can be used to call a function. Delegates are used to perform operations that take a long time to complete, such as loading a file or waiting for a network response.

// What is a lambda expression?
// A lambda expression is a function that is defined inline. Lambda expressions are used to perform operations that take a long time to complete, such as loading a file or waiting for a network response.


// What is the difference between DOCKER and VIRTUAL MACHINE?
// Docker is a containerization platform that allows you to package and run applications in a lightweight, portable, and consistent manner. Docker containers are isolated from each other and from the host system, making them a great choice for running multiple applications on the same machine.

// Virtual Machine is a software that creates a virtual environment that is similar to a physical machine. Virtual machines are used to run multiple operating systems on the same machine.

// Docker for COdesys?
// Docker for COdesys is a tool that allows you to containerize your COdesys applications. It is a great way to package and run your COdesys applications in a consistent and isolated environment.