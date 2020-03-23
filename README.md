# University Registar - March 20, 2020

### Created by: Brandan Sayarath, Zakkrey Short, Jeremy K. Padot

## Description

This proejct is an app for a University registrar to keep track of students and courses.

## Behavior Driven Development Specifications

| Specification             | Input 	|     Output      |
|-------------------------	|-------	|----------------	|
|When user visits '/' root route, display splash page with link to '/courses' and '/students' | user visits '/' route | display home|
| When user visits '/courses' display list of all courses, each with 'view detail' link, and 'add new courses' button | user visits '/courses' | display list of courses, and 'Add new courses' button|
| When user clicks 'Add new courses' button, redirect to courses form | clicks 'add new courses' | redirect to '/courses/create'|
| When user visits '/courses/create' show new courses form with field for "Course Name" and "Course Speciality" | user visits '/courses/create' | show courses form |
| When user clicks submit on courses form, add new courses to List and redirect to '/courses' | clicks submit | Add new courses to List, redirect to '/courses' |
| When user visits '/courses/{id}', they will see the details of the courses | user visits courses page | show courses info |
| When user visits '/students' display list of all students, each with 'view detail' link, and 'add new student' button | user visits '/students' | display list of students, and 'Add new student' button|
| When user clicks 'Add new student' button, redirect to student form | clicks 'add new student' | redirect to '/student/create'|
| When user visits '/student/create' show new student form with field for "Student Name" | user visits '/student/create' | show courses form |
| When user clicks submit on student form, add new student to List and redirect to '/students' | clicks submit | Add new student to List, redirect to '/students' |


## Setup/Installation Requirements

Clone this repository via Terminal using the following commands:
* ```$ cd desktop```
* ```$ git clone https://github.com/kalepadot/epicodus-university-registrar```
* ```$ cd epicodus-university-registrar```

To run the program, navigate to the Registar production folder by typing the following into the terminal: 

* ```$ cd Registar```

Then restore dependencies by typing:
* ```$ dotnet restore```

You can now run the program by typing:
* ```$ dotnet run```


## Support and Contact

Please email Brandan Sayarath, Zakk Short, or Jeremy Padot for any questions.

## Technologies Used

This program was created with:

* C#
* ASP.NET Core MVC 2.2
* Entity Framework
* MySQL
* MySQL Workbench 
* HTML5

## License

This code is licensed under MIT permissive free software license

Copyright (c) 2020 Brandan Sayarath, Zakkrey Short, Jeremy K. Padot

