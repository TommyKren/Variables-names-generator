using System;
namespace Variable_name_generator
{
    /// <summary>
    /// Class for console screen rendering
    /// </summary>
    public class Screen_rendering
    {
        //*******************************************************************************
        // Variables

        /// <summary>
        /// Applications name
        /// </summary>
        public string appName { get; private set; } = "";

        /// <summary>
        /// Screen width in number of characters
        /// </summary>
        public int screenWidth { get; private set; } = 20;

        /// <summary>
        /// Character used for rendering borders
        /// </summary>
        public char borderChar { get; set; } = '*';

        /// <summary>
        /// Space between borders and screen content
        /// </summary>
        public int borderSpacing { get; private set; } = 4;

        /// <summary>
        /// Inicialize renderer with DEFAULT settings and WITHOUT app name
        /// </summary>
        public Screen_rendering()
        {

        }

        /// <summary>
        /// Inicialize renderer with custom window size and WITHOUT app name
        /// </summary>
        public Screen_rendering(int _screenWidth)
        {
            if (_screenWidth > screenWidth)
                this.screenWidth = _screenWidth;
        }

        /// <summary>
        /// Inicialize renderer with custom window size and app name
        /// </summary>
        /// <param name="_screenWidth">Screen width</param>
        /// <param name="_appName">Application name</param>
        public Screen_rendering(int _screenWidth, string _appName)
        {
            appName = _appName;
            if (screenWidth < _screenWidth)
                screenWidth = _screenWidth;
            if (_appName.Length >= (screenWidth - (2 * borderSpacing)))
                appName = _appName.Remove(screenWidth - (2 * borderSpacing));
            else
                appName = _appName;
        }

        //*******************************************************************************
        // Writing lines

        /// <summary>
        /// Write full fill border line "***...***"
        /// </summary>
        public void Write_border_line()
        {
            for (int i = 1; i <= screenWidth; i++)
            {
                Console.Write(borderChar);
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// Write line with empty space between borders "*  ...  *"
        /// </summary>
        public void Write_empty_line()
        {
            for (int i = 1; i <= screenWidth; i++)
            {
                if (i == 1 || i == screenWidth)
                    Console.Write(borderChar);
                else
                    Console.Write(' ');

            }
            Console.WriteLine();
        }

        /// <summary>
        /// Format any string for use in window
        /// </summary>
        /// <param name="_outputText">Text formating for use in output line</param>
        public string Format_text_line(string _outputText)
        {
            string textLine = "";

            textLine += borderChar;

            for (int i = 1; i < borderSpacing; i++)
            {
                textLine += " ";
            }

            if (_outputText.Length + textLine.Length <= screenWidth - borderSpacing)
                textLine += _outputText;
            else
                textLine += "Adjust win width";


            for (int i = textLine.Length + 1; i <= screenWidth; i++)
            {
                if (i == screenWidth)
                    textLine += borderChar;
                else
                    textLine += " ";
            }
            return textLine;
        }

        /// <summary>
        /// Format line with possible feedback options
        /// </summary>
        /// <param name="_outputText">Write preformated text with feedback options</param>
        public string Format_feedback_line(string _outputText)
        {
            _outputText = Format_text_line(_outputText);
            return _outputText.Replace(' ', borderChar);
        }

        /// <summary>
        /// Write line from preformated string
        /// </summary>
        /// <param name="_outputText">Write preformated general output line</param>
        public void Write_preformated_line(string _outputText)
        {
            Console.WriteLine(_outputText);
        }

        /// <summary>
        /// Write line from preformated string
        /// </summary>
        /// <param name="_outputTextLines">Write multiple preformated general output line</param>
        public void Write_multiple_options_line(List<string> _outputTextLines)
        {
            foreach (var textLine in _outputTextLines)
            {
                Write_preformated_line(Format_text_line(textLine));
            }
        }

        /// <summary>
        /// Render question window with options and 
        /// </summary>
        public void Write_input_line()
        {
            Console.Write("\nInput << ");
        }

        //*******************************************************************************
        // Rendering screens

        /// <summary>
        /// Render top frame with app name
        /// </summary>
        public void Render_appname_frame()
        {
            Console.Clear();
            Write_border_line();

            if (appName == "")
                return;
            Console.Title = appName;

            Write_empty_line();
            Write_preformated_line(Format_text_line(appName));
            Write_empty_line();

            Write_border_line();
        }

        /// <summary>
        /// Render screen with multiple lines and feedback choices
        /// </summary>
        public void Render_question_screen(List<string> _outputTextLines, string _feedbackOptions)
        {
            Render_appname_frame();

            Write_empty_line();
            Write_multiple_options_line(_outputTextLines);
            Write_empty_line();

            Write_preformated_line(Format_feedback_line(_feedbackOptions));
            Write_input_line();
        }

        // Overrided method with instance string info
        public override string ToString()
        {
            string outputString = "Renderer : Window width : " + screenWidth + ", app name : ";

            if (appName != "")
                outputString += appName;
            else
                outputString += "null";

            return outputString;
        }
    }
}

