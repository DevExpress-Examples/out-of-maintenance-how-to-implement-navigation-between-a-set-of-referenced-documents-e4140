<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to implement navigation between a set of referenced documents


<p>This example illustrates how to handle the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_HyperlinkClicktopic"><u>RichEditControl.HyperlinkClick Event</u></a> to implement navigation logic (see <a href="http://stackoverflow.com/questions/1313788/how-does-the-back-button-in-a-web-browser-work"><u>How does the Back button in a web browser work?</u></a>) for a set of referenced HTML documents. This logic might be useful if you wish to organize a help system in your application. Here is the major code that is responsible for this logic:<br />
</p>

```cs
        private void richEditControl1_HyperlinkClick(object sender, HyperlinkClickEventArgs e) {
            BeginInvoke((MethodInvoker)delegate() {
                NavigateTo(e.Hyperlink.NavigateUri, true);
            });
            e.Handled = true;
        }
        ...
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

```

<p>Note that the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeHyperlink_NavigateUritopic"><u>Hyperlink.NavigateUri Property</u></a> is used to retrieve relative the location of a referenced document. This location is stored in the source document in the following form:<br /> 
</p><para><code lang="html"><a href="./CS/Documents/AndrewFuller.html"><span class="csBB08E6F5">Andrew Fuller</span></a>

<br/>


