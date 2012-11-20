using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DialoguePrototype
{
    class Entry
    {
        #region Fields

        /// <summary>
        /// The GUID of the entry.
        /// </summary>
        Guid id;

        /// <summary>
        /// The text representing the body of the prompt.
        /// </summary>
        string body { get; set; }
        
        /// <summary>
        /// The text representing how the User should proceed, should there be no
        /// responses
        /// </summary>
        const string usageText = "\n{enter}...";

        #endregion

        #region Properties

        /// <summary>
        /// Gets the ID.
        /// </summary>
        public Guid Id
        {
            get { return id; }
        }

        /// <summary>
        /// Gets the Body.
        /// </summary>
        public String Body
        {
            get { return body; }
        }

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id">the GUID of this prompt in the database.</param>
        /// <param name="speaker">a String representing the name of the speaker</param>
        /// <param name="body">a String representing the body of this prompt</param>
        /// <param name="promptActions">
        /// a list of <see cref="IDialogueAction"/>Actions</see> to be executed when this prompt is displayed
        /// </param>
        /// <param name="responseRequired">whether or not the prompt has responses</param>
        public Entry(Guid id, String body)
        {
            this.id = id;
            this.body = body;
        }

        public override string ToString()
        {
            return this.body;
        }

        /// <summary>
        /// Appends the usage text to the body. 
        /// Used for prompts that don't have any responses.
        /// </summary>
        internal void IncludeUsageText()
        {
            this.body = this.body + usageText;
        }
    }
}
