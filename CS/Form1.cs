using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraRichEdit;
using DevExpress.Portable.Input;

namespace RichEditNavigation {
    public partial class Form1 : Form {
        string basePath = "Documents";
        string startPage = "Index.html";
        List<string> historyItems = new List<string>();
        int currentHistoryItemIndex = 0;

        public Form1() {
            InitializeComponent();
            richEditControl1.ReadOnly = true;
            richEditControl1.Options.Hyperlinks.ModifierKeys = PortableKeys.None;
            NavigateTo(startPage, true);
        }

        private void richEditControl1_HyperlinkClick(object sender, HyperlinkClickEventArgs e) {
            BeginInvoke((MethodInvoker)delegate() {
                NavigateTo(e.Hyperlink.NavigateUri, true);
            });
            e.Handled = true;
        }

        private void richEditControl1_KeyDown(object sender, KeyEventArgs e) {
            if (currentHistoryItemIndex != 0 && e.KeyCode == Keys.Back)
                btnBackward_Click(btnBackward, EventArgs.Empty);
        }

        private void btnBackward_Click(object sender, System.EventArgs e) {
            NavigateTo(historyItems[--currentHistoryItemIndex], false);
        }

        private void btnForward_Click(object sender, System.EventArgs e) {
            NavigateTo(historyItems[++currentHistoryItemIndex], false);
        }

        private void NavigateTo(string page, bool addToHistory) {
            if (addToHistory) {
                while (historyItems.Count > currentHistoryItemIndex + 1)
                    historyItems.RemoveAt(historyItems.Count - 1);
                
                historyItems.Add(page);
                currentHistoryItemIndex = historyItems.Count - 1;
            }
            richEditControl1.LoadDocument(Path.Combine(basePath, page));
            UpdateUI();
        }

        private void UpdateUI() {
            btnBackward.Enabled = currentHistoryItemIndex != 0;
            btnForward.Enabled = currentHistoryItemIndex != historyItems.Count - 1;
        }
    }
}