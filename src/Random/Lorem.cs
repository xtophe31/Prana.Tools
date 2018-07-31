// http://www.gutgames.com/post/Lorem-Ipsum-Generator-in-C.aspx

using System.Text;

namespace Prana.Tools
{
    public partial class Random
    {
        #region lorem ipsum words -----------------------------------------------------------------

        readonly string[] _words = { "consetetur", "sadipscing", "elitr", "sed", "diam", "nonumy", "eirmod",
             "tempor", "invidunt", "ut", "labore", "et", "dolore", "magna", "aliquyam", "erat", "sed", "diam", "voluptua",
             "at", "vero", "eos", "et", "accusam", "et", "justo", "duo", "dolores", "et", "ea", "rebum", "stet", "clita",
             "kasd", "gubergren", "no", "sea", "takimata", "sanctus", "est", "lorem", "ipsum", "dolor", "sit", "amet",
             "lorem", "ipsum", "dolor", "sit", "amet", "consetetur", "sadipscing", "elitr", "sed", "diam", "nonumy", "eirmod",
             "tempor", "invidunt", "ut", "labore", "et", "dolore", "magna", "aliquyam", "erat", "sed", "diam", "voluptua",
             "at", "vero", "eos", "et", "accusam", "et", "justo", "duo", "dolores", "et", "ea", "rebum", "stet", "clita",
             "kasd", "gubergren", "no", "sea", "takimata", "sanctus", "est", "lorem", "ipsum", "dolor", "sit", "amet",
             "lorem", "ipsum", "dolor", "sit", "amet", "consetetur", "sadipscing", "elitr", "sed", "diam", "nonumy", "eirmod",
             "tempor", "invidunt", "ut", "labore", "et", "dolore", "magna", "aliquyam", "erat", "sed", "diam", "voluptua",
             "at", "vero", "eos", "et", "accusam", "et", "justo", "duo", "dolores", "et", "ea", "rebum", "stet", "clita",
             "kasd", "gubergren", "no", "sea", "takimata", "sanctus", "est", "lorem", "ipsum", "dolor", "sit", "amet", "duis",
             "autem", "vel", "eum", "iriure", "dolor", "in", "hendrerit", "in", "vulputate", "velit", "esse", "molestie",
             "consequat", "vel", "illum", "dolore", "eu", "feugiat", "nulla", "facilisis", "at", "vero", "eros", "et",
             "accumsan", "et", "iusto", "odio", "dignissim", "qui", "blandit", "praesent", "luptatum", "zzril", "delenit",
             "augue", "duis", "dolore", "te", "feugait", "nulla", "facilisi", "lorem", "ipsum", "dolor", "sit", "amet",
             "consectetuer", "adipiscing", "elit", "sed", "diam", "nonummy", "nibh", "euismod", "tincidunt", "ut", "laoreet",
             "dolore", "magna", "aliquam", "erat", "volutpat", "ut", "wisi", "enim", "ad", "minim", "veniam", "quis",
             "nostrud", "exerci", "tation", "ullamcorper", "suscipit", "lobortis", "nisl", "ut", "aliquip", "ex", "ea",
             "commodo", "consequat", "duis", "autem", "vel", "eum", "iriure", "dolor", "in", "hendrerit", "in", "vulputate",
             "velit", "esse", "molestie", "consequat", "vel", "illum", "dolore", "eu", "feugiat", "nulla", "facilisis", "at",
             "vero", "eros", "et", "accumsan", "et", "iusto", "odio", "dignissim", "qui", "blandit", "praesent", "luptatum",
             "zzril", "delenit", "augue", "duis", "dolore", "te", "feugait", "nulla", "facilisi", "nam", "liber", "tempor",
             "cum", "soluta", "nobis", "eleifend", "option", "congue", "nihil", "imperdiet", "doming", "id", "quod", "mazim",
             "placerat", "facer", "possim", "assum", "lorem", "ipsum", "dolor", "sit", "amet", "consectetuer", "adipiscing",
             "elit", "sed", "diam", "nonummy", "nibh", "euismod", "tincidunt", "ut", "laoreet", "dolore", "magna", "aliquam",
             "erat", "volutpat", "ut", "wisi", "enim", "ad", "minim", "veniam", "quis", "nostrud", "exerci", "tation",
             "ullamcorper", "suscipit", "lobortis", "nisl", "ut", "aliquip", "ex", "ea", "commodo", "consequat", "duis",
             "autem", "vel", "eum", "iriure", "dolor", "in", "hendrerit", "in", "vulputate", "velit", "esse", "molestie",
             "consequat", "vel", "illum", "dolore", "eu", "feugiat", "nulla", "facilisis", "at", "vero", "eos", "et", "accusam",
             "et", "justo", "duo", "dolores", "et", "ea", "rebum", "stet", "clita", "kasd", "gubergren", "no", "sea",
             "takimata", "sanctus", "est", "lorem", "ipsum", "dolor", "sit", "amet", "lorem", "ipsum", "dolor", "sit",
             "amet", "consetetur", "sadipscing", "elitr", "sed", "diam", "nonumy", "eirmod", "tempor", "invidunt", "ut",
             "labore", "et", "dolore", "magna", "aliquyam", "erat", "sed", "diam", "voluptua", "at", "vero", "eos", "et",
             "accusam", "et", "justo", "duo", "dolores", "et", "ea", "rebum", "stet", "clita", "kasd", "gubergren", "no",
             "sea", "takimata", "sanctus", "est", "lorem", "ipsum", "dolor", "sit", "amet", "lorem", "ipsum", "dolor", "sit",
             "amet", "consetetur", "sadipscing", "elitr", "at", "accusam", "aliquyam", "diam", "diam", "dolore", "dolores",
             "duo", "eirmod", "eos", "erat", "et", "nonumy", "sed", "tempor", "et", "et", "invidunt", "justo", "labore",
             "stet", "clita", "ea", "et", "gubergren", "kasd", "magna", "no", "rebum", "sanctus", "sea", "sed", "takimata",
             "ut", "vero", "voluptua", "est", "lorem", "ipsum", "dolor", "sit", "amet", "lorem", "ipsum", "dolor", "sit",
             "amet", "consetetur", "sadipscing", "elitr", "sed", "diam", "nonumy", "eirmod", "tempor", "invidunt", "ut",
             "labore", "et", "dolore", "magna", "aliquyam", "erat", "consetetur", "sadipscing", "elitr", "sed", "diam",
             "nonumy", "eirmod", "tempor", "invidunt", "ut", "labore", "et", "dolore", "magna", "aliquyam", "erat", "sed",
             "diam", "voluptua", "at", "vero", "eos", "et", "accusam", "et", "justo", "duo", "dolores", "et", "ea",
             "rebum", "stet", "clita", "kasd", "gubergren", "no", "sea", "takimata", "sanctus", "est", "lorem", "ipsum" };

        #endregion

        /// <summary>
        /// Creates a Lorem Ipsum sentence.
        /// </summary>
        /// <param name="numberOfWords">Number of words for the sentence</param>
        /// <returns>A string containing Lorem Ipsum text</returns>
        public string NextLoremIpsum(int numberOfWords)
        {
            var builder = new StringBuilder();
            builder.Append(String.ToFirstCharacterUpperCase(_words[Next(_words.Length)]));
            for (int x = 1; x < numberOfWords; ++x)
            {
                builder.Append(" ").Append(_words[Next(_words.Length)]);
            }
            builder.Append(".");
            return builder.ToString();
        }

        /// <summary>
        /// Creates a Lorem Ipsum paragraph.
        /// </summary>
        /// <param name="numberOfParagraphs">Number of paragraphs</param>
        /// <param name="maxSentenceLength">Maximum sentence length</param>
        /// <param name="minSentenceLength">Minimum sentence length</param>
        /// <param name="numberOfSentences">Number of sentences per paragraph</param>
        /// <param name="htmlFormatting">Determines if this should use HTML formatting or not</param>
        /// <returns>A string containing Lorem Ipsum text</returns>
        public string NextLoremIpsum(int numberOfParagraphs, int numberOfSentences, int minSentenceLength, int maxSentenceLength, bool htmlFormatting)
        {
            var builder = new StringBuilder();
            if (htmlFormatting)
                builder.Append("<p>");
            builder.Append("Lorem ipsum dolor sit amet. ");
            for (int y = 0; y < numberOfSentences; ++y)
            {
                builder.Append(NextLoremIpsum(Next(minSentenceLength, maxSentenceLength))).Append(" ");
            }
            if (htmlFormatting)
                builder.Append("</p>");
            for (int x = 1; x < numberOfParagraphs; ++x)
            {
                if (htmlFormatting)
                    builder.Append("<p>");
                for (int y = 0; y < numberOfSentences; ++y)
                {
                    builder.Append(NextLoremIpsum(Next(minSentenceLength, maxSentenceLength))).Append(" ");
                }
                if (htmlFormatting)
                    builder.Append("</p>");
                else
                    builder.Append(System.Environment.NewLine).Append(System.Environment.NewLine);
            }
            return builder.ToString();
        }

        /// <summary>
        /// Creates a Lorem Ipsum paragraph.
        /// </summary>
        /// <param name="numberOfParagraphs">Number of paragraphs</param>
        /// <param name="maxSentenceLength">Maximum sentence length</param>
        /// <param name="minSentenceLength">Minimum sentence length</param>
        /// <param name="numberOfSentences">Number of sentences per paragraph</param>
        /// <returns>A string containing Lorem Ipsum text</returns>
        public string NextLoremIpsum(int numberOfParagraphs, int numberOfSentences, int minSentenceLength, int maxSentenceLength)
        {
            return NextLoremIpsum(numberOfParagraphs, numberOfSentences, minSentenceLength, maxSentenceLength, false);
        }


    }
}
