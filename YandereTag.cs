using System;
using System.Linq;
using System.Collections.Generic;

namespace Yande.re
{
    public class YandereTag
    {
        public List<string> Tags = new List<string>();

        public YandereRating Rating = YandereRating.all;
        public int Limit = 100;
        public int Page = 1;

        public string GenerateTags()
        {
            string TagString = Tags.Aggregate((i, b) => $"{i}+{b}");
            if (Rating != YandereRating.all)
            {
                switch (Rating)
                {
                    case YandereRating.Safe:
                        TagString = $"rating:s+{TagString}";
                        break;
                    case YandereRating.Questionable:
                        TagString = $"rating:q+{TagString}";
                        break;
                    case YandereRating.Explicit:
                        TagString = $"rating:e+{TagString}";
                        break;
                }
            }

            return $"tags={TagString}&limit={Limit}&page={Page}";
        }
    }
}