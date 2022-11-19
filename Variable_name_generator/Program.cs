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
            string[] textOutput = { "Choose your format of variable", "  1) number", "  2) text", "  3) character", "  4) general object", "  5) data structure" };

            Screen_rendering screen_rendering = new Screen_rendering(80, "Generator of variables names");

            screen_rendering.Write_border_line();

            screen_rendering.Write_empty_line();
            screen_rendering.Write_preformated_line(screen_rendering.Format_text_line(screen_rendering.ToString()));
            screen_rendering.Write_empty_line();

            screen_rendering.Write_border_line();

            screen_rendering.Write_empty_line();
            screen_rendering.Write_multiple_options_line(textOutput);
            screen_rendering.Write_empty_line();

            screen_rendering.Write_preformated_line(screen_rendering.Format_feedback_line("[Y]es,[N]o"));
            screen_rendering.Write_input_line();

            Console.ReadLine();
            Console.Clear();
            Console.ReadKey();

        }
    }
}