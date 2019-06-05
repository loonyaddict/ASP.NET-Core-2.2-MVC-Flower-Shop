using System;

namespace FlowerShop.Models
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext dbContext;

        public FeedbackRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddFeedback(Feedback feedback)
        {
            dbContext.Feedbacks.Add(feedback);
            dbContext.SaveChanges();
        }
    }
}