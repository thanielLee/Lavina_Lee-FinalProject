using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavina_Lee_FinalProject
{
    public class Review
    {
        public int game_id;
        public int user_id;
        public int review_id;
        public string review_description;
        public float review_rating;

        public Review(int review_id, int game_id, int user_id, string review_description, float review_rating)
        {
            this.review_id = review_id;
            this.game_id = game_id;
            this.user_id = user_id;
            this.review_description = review_description;
            this.review_rating = review_rating;
        }
    }
}
