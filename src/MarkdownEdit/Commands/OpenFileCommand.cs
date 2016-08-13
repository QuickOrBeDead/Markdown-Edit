﻿using System.Windows;
using System.Windows.Input;
using MarkdownEdit.Controls;

namespace MarkdownEdit.Commands
{
    internal static class OpenFileCommand
    {
        public static readonly RoutedCommand Command = ApplicationCommands.Open;

        static OpenFileCommand()
        {
            Application.Current.MainWindow.CommandBindings.Add(new CommandBinding(Command, Execute));
        }

        private static void Execute(object sender, ExecutedRoutedEventArgs e)
        {
            var mainWindow = (MainWindow)sender;
            mainWindow.Editor.OpenFile(e.Parameter as string);
        }
    }
}