// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Runtime.InteropServices;
// using System.Text;

// namespace A6;
// struct TypeOfSize1()
// {
//     char sa = 'a';
// }

// struct TypeOfSize5()
// {
//     TypeOfSize1 s1;
//     TypeOfSize1 s2;
//     TypeOfSize1 s3;
//     TypeOfSize1 s4;
//     TypeOfSize1 s5;
// }

// struct TypeOfSize22()
// {
//     TypeOfSize5 s1;
//     TypeOfSize5 s2;
//     TypeOfSize5 s3;
//     TypeOfSize5 s4;
//     TypeOfSize1 a1;
//     TypeOfSize1 a2;
// }

// struct TypeOfSize125()
// {
//     TypeOfSize22 s1;
//     TypeOfSize22 s2;
//     TypeOfSize22 s3;
//     TypeOfSize22 s4;
//     TypeOfSize22 s5;
//     TypeOfSize5 a1;
//     TypeOfSize5 a2;
//     TypeOfSize5 a3;
// }

// struct TypeOfSize1024()
// {
//     TypeOfSize125 s1;
//     TypeOfSize125 s2;
//     TypeOfSize125 s3;
//     TypeOfSize125 s4;
//     TypeOfSize22 a1;
//     TypeOfSize1 b1;
//     TypeOfSize1 b2;
// }
// struct TypeOfSize1024_4()
// {
//     TypeOfSize1024 a1;
//     TypeOfSize1024 a2;
//     TypeOfSize1024 a3;
//     TypeOfSize1024 a4;
// }

// struct TypeOfSize1024_16()
// {
//     TypeOfSize1024_4 a1;
//     TypeOfSize1024_4 a2;
//     TypeOfSize1024_4 a3;
//     TypeOfSize1024_4 a4;
// }

// struct TypeOfSize32768()
// {
//     TypeOfSize1024_16 a1;
//     TypeOfSize1024_16 a2;
// }