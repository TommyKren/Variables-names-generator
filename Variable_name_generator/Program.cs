/*
*********************************************************
*                                                       *
*        !!  Variables names generator app  !!          *
*                                                       *
*   App generating and translating name for variables   *
*                                                       *
*                   Tomas Krenek                        *
*                                                       *
*********************************************************
*/

using System;

namespace Variable_name_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Name_processing name_processing = new Name_processing();
            Screen_rendering screen_rendering = new Screen_rendering(60, "Generator of variables names");

            screen_rendering.Render_question_screen(name_processing.infoScreen, name_processing.optionsLine);

            Console.ReadLine();
            Console.Clear();
            Console.ReadKey();

        }
    }
}