using System;
using System.Windows.Forms;

namespace BreakingApp
{
    internal class ErrorHelper
    {
        private static RichTextBox target = null;

        // Errorlogger to target rtbStatus
        public void SetTarget(RichTextBox richText)
        {
            target = richText;
        }

        public void Log(string format, params object[] args)
        {
            format += "\r\n";

            try
            {
                if (target.InvokeRequired)
                {
                    target.Invoke(new Action(() =>
                        target.AppendText(string.Format(format, args))
                    ));
                }
                else
                {
                    target.AppendText(string.Format(format, args));
                }
            }
            catch { }
        }

        public static ErrorHelper Instance
        {
            get => new ErrorHelper();
        }
    }
}