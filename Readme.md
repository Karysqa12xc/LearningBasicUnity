# Pop quiz - dealing with scripts(Chapter 1)
1. What type of relationship do Unity and Visual Studio share?
> Unity and Visual Studio have a symbiotic relationship
2. The Scripting Reference supplies example code in regards to using a 
particular Unity component or feature. Where can you find more detailed 
(non-code-related) information about Unity components?
> The Reference Manual
3. The Scripting Reference is a large document. How much of it do you have to 
memorize before attempting to write a script?
> None, as it is a reference document, not a test
4. When is the best time to name a C# script?
> When the new file appears in the Project tab with the filename in edit mode, which 
will make the class name the same as the filename and prevent naming conflicts
# Pop quiz – C# building blocks(Chapter 2)
1. What is the main purpose of a variable?
> Storing a specific type of data for use elsewhere in a C# file
2. What role do methods play in scripts?
> Methods store executable lines of code for fast and efficient reuse
3. How does a script become a component?
> By adopting MonoBehaviour as its parent class and attaching it to a GameObject
4. What is the purpose of dot notation?
> To access variables and methods of components or files attached to different GameObjects
# Pop quiz – variables and methods(Chapter 3)
1. What is the proper way to write a variable name in C#?
> Using camelCase
2. How do you make a variable appear in Unity's Inspector window?
> Declare the variable as public
3. What are the four access modifiers available in C#?
> public, private, protected, and internal
4. When are explicit conversions needed between types?
> When an implicit conversion doesn't already exist
5. What are the minimum requirements for defining a method?
> The type of data returned from the method, the name of the method with parentheses, and a pair of curly brackets for the code block
6. What is the purpose of the parentheses at the end of the method name?
> To allow parameter data to be passed into the code block
7. What does a return type of void mean in a method definition?
> The method will not return any data
8. How often is the Update() method called by Unity? 
> The Update() method is called every frame
# Pop quiz 1 – if, and, or but(Chapter 4)
1. What values are used to evaluate if statements?
> True or false
2. Which operator can turn a true condition false or a false condition true?
> The NOT operator, written with the exclamation mark symbol (!)
3. If two conditions need to be true for an if statement's code to execute, what 
logical operator would you use to join the conditions?
> The AND operator, written with double ampersand symbols (&&)
4. If only one of two conditions needs to be true to execute an if statement's 
code, what logical operator would you use to join the two conditions?
>  The OR operator, written with double bars (||)
# Pop quiz 2 – all about collections(Chapter 4)
1. What is an element in an array or list?
> The location where data is stored
2. What is the index number of the first element in an array or list?
> The first element in an array or list is 0, as they are both zero-indexed
3. Can a single array or list store different types of data?
> No — when an array or a list is declared, the type of data it stores is defined, making it impossible for elements to be of different types
4. How can you add more elements to an array to make room for more data?
> An array cannot be dynamically expanded once it is initialized, which is why lists are a more flexible choice as they can be dynamically modified
# Pop quiz – all things OOP (Chapter 5)
1. What method handles the initialization logic inside a class?
> The constructor
2. Being value types, how are structs passed?
> By copy, rather than by reference like classes
3. What are the main tenets of OOP?
> Encapsulation, inheritance, composition, and polymorphism
4. Which GameObject class method would you use to find a component on the 
same object as the calling class?
> GetComponent
# Pop quiz – basic Unity features(Chapter 6)
1. Cubes, capsules, and spheres are examples of what kind of GameObject?
> Primitives
2. What axis does Unity use to represent depth, which gives scenes their 3D 
appearance? 
> The z axis
3. How do you turn a GameObject into a reusable Prefab?
> Drag the GameObject into the Prefabs folder
4. What unit of measurement does the Unity animation system use to record 
object animations?
> Keyframes
# Pop quiz – player controls and physics(Chapter 7)
1. What data type would you use to store 3D movement and rotation 
information?
> Vector3
2. What built-in Unity component allows you to track and modify player 
controls?
> InputManager
3. Which component adds real-world physics to a GameObject?
> A Rigidbody component
4. What method does Unity suggest using to execute physics-related code on 
GameObjects?
> FixedUpdate
# Pop quiz – working with mechanics(Chapter 8)
1. What type of data do enumerations store?
> A set or collection of named constants that belong to the same variable
2. How would you create a copy of a Prefab GameObject in an active scene?
> Using the Instantiate() method with an existing Prefab
3. Which variable properties allow you to add functionality when their value is referenced or modified?
> The get and set accessors
4. Which Unity method displays all UI objects in the scene?
> OnGUI()
# Pop quiz – AI and navigation(Chapter 9)
1. How is a NavMesh component created in a Unity scene?
> It's generated automatically from the level geometry
2. What component identifies a GameObject to a NavMesh?
> NavMeshAgent
3. Executing the same logic on one or more sequential objects is an example of which programming technique?
> Procedural programming
4. What does the DRY acronym stand for?
> Don't repeat yourself
# Pop quiz – leveling up (Chapter 10)
1. Which keyword would mark a variable as unmodifiable but requires an initial value?
> Readonly
2. How would you create an overloaded version of a base method?
> Change the number of method parameters or their parameter types
3. What is the main difference between classes and interfaces?
> Interfaces cannot have method implementations or stored variables
4. How would you solve a namespace conflict in one of your classes?
> Create a type alias to differentiate conflicting namespaces
# Pop quiz - intermediate collections (Chapter 11)
1. Which collection type stores its elements using the LIFO model?
> LIFO
2. Which method lets you query the next element in a stack without removing 
it?
> Peek
3. Can stacks and queues store null values?
> Yes
4. How would you subtract one HashSet from another?
> ExcepWith
# Pop quiz – data management (Chapter 12)
1. Which namespace gives you access to the Path and Directory classes?
> The System.IO namespace
2. In Unity, what folder path do you use to save data between runs of your 
game?
> Application.persistentDataPath 
3. What data type do Stream objects use to read and write information to files?
> Streams read and write data as bytes
4. What happens when you serialize an object into JSON?
> The entire C# class object is converted into JSON format 
# Pop quiz – intermediate C# (Chapter 13)
1. What is the difference between a generic and non-generic class?
> Generic classes need to have a defined type parameter
2. What needs to match when assigning a value to a delegate type?
> The values method and the delegates method signature
3. How would you unsubscribe from an event?
> The -= operator
4. Which C# keyword would you use to send out an exception in your code?
> The throw keyword
# Completed the book (Chapter 14)

