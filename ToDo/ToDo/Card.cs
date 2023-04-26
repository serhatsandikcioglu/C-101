using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class Card
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int PersonId { get; set; }
        public cardSizeType Size { get; set; }

        public Card(string title,string content,int personId,cardSizeType size)
        {
            Title = title;
            Content = content;
            PersonId = personId;
            Size = size;
        }
        public enum cardSizeType
        {
            XS = 1,S,M,L,XL
        }
    }
}
