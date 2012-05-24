/**************************************************************************
 * Twitter Search Client for Microsoft Surface 2.0
 * Code by sascha.corti@microsoft.com 
 * Bugs after this line.
 * 
 *  \__/      \__/       \__/       \__/       \__/       \__/       \__/
 *  (oo)      (o-)       (@@)       (xx)       (--)       (  )       (OO)
 * //||\\    //||\\     //||\\     //||\\     //||\\     //||\\     //||\\
 *  bug       bug        bug/w      dead       bug       blind     bug after
 *          winking    hangover     bug      sleeping     bug      seeing a
 *                                                                  female
 *                                                                   bug
 *                                                                   
 ***************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Surface;
using Microsoft.Surface.Presentation;
using Microsoft.Surface.Presentation.Controls;
using Microsoft.Surface.Presentation.Input;

namespace SurfaceTwitterSearch
{
    /// <summary>
    /// Interaction logic for TagVisualization1.xaml
    /// </summary>
    public partial class TagVisualization1 : TagVisualization
    {
        public TagVisualization1()
        {
            InitializeComponent();
        }

        private void TagVisualization1_Loaded(object sender, RoutedEventArgs e)
        {
            //TODO: customize TagVisualization1's UI based on this.VisualizedTag here
        }

        public event EventHandler ExecuteMethod;
        protected virtual void OnExecuteMethod()
        {
            var query = new MyQuery();
            query.Text = surfaceTextBox1.Text;
            if (ExecuteMethod != null) ExecuteMethod(this, query);
        }
        public void surfaceButton1_Click(object sender, EventArgs e)
        {
            OnExecuteMethod();
        }
    }

    public class MyQuery : EventArgs
    {
        public string Text;
    }
}

