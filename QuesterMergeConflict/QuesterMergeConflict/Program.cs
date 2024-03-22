using QuesterMergeConflict;

Package package = new Package();
package.AddQuestion(new Question("dffd", "fdfd"));
package.AddQuestion(new Question("dffd", "fdfd2"));
package.AddQuestion(new Question("dffd", "fdfd1"));
package.SaveToFileAsync("dss.txt");