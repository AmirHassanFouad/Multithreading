using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace AsyncAwaitProgram
{
    public partial class Form1 : Form
    {
        //public int Calc()
        //{
        //    Thread.Sleep(5000);
        //    return 123;
        //}

        public async Task<int> CalcAsync()
        {
            //return Task.Factory.StartNew(() =>
            //{
            //  Thread.Sleep(5000);
            //  return 123;
            //});

            // like above syntactic sugar
            //instead of thread.Sleep
            await Task.Delay(5000); // creates a task the completes after a time delay by taking a thread from the thread pool and runs a task
            return 123;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCalc_Click(object sender, EventArgs e)
        {
            int value = await CalcAsync();
            lblResult.Text = value.ToString(); // this line happens on the ui thread which is why everything is ok because if 
            // we did this on the thread where this thing was executed in this task then we would have a problem
            // with have a cross-thread issue


            await Task.Delay(5000);

            using (var wc = new WebClient())
            {
                string data = await
                    wc.DownloadStringTaskAsync("http://google.com/robots.txt");
                lblResult.Text = data.Split('\n')[0].Trim();
            }


            // when you await, you abandon current thread, fire up a new one and then do a context-preserving
            // continuation of the code that's left
            //Task.Run is like  Task.Factory.StartNew "a shortuct" with bunch of default values
            // with Unwrap() the result => so if you have an async lambda or a delegate being passed in
            // is going to unwrap it for you and it works correctly but both regular methods or async methods
            // example
            // await can be used as the language equivalent of Unwrap()
            int result = await Task.Run(async delegate//()=>
            {
                await Task.Delay(1000);
                return 42;
            });
            //example above is like the example below
            int result2 = await await Task.Factory.StartNew(
                async delegate
                {
                    await Task.Delay(1000);
                    return 42;
                },
                  CancellationToken.None,
                    TaskCreationOptions.DenyChildAttach,
                    TaskScheduler.Default);

            //so Task.Run is like
            //    Task.Factory.StartNew(something,
            //        CancellationToken.None,
            //        TaskCreationOptions.DenyChildAttach,
            //        TaskScheduler.Default);

            //var calculation = CalcAsync();
            //calculation.ContinueWith(t =>
            //{
            //    lblResult.Text = t.Result.ToString();
            //}, TaskScheduler.FromCurrentSynchronizationContext());
            //TaskScheduler.FromCurrentSynchronizationContext() => to make sure that this all gets called on the ui thread
        }
    }
}
