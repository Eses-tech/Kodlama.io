using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 =new Game();
            game1.Id = 1;
            game1.GameName = "Total War";
            game1.GameType = "Strateji";


            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.FirstName = "AYDIN";
            gamer.LastName = "TUZ";
            gamer.IdentityNumber = 11111111111;
            gamer.BirthYear = 1986;
            

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "Sevgililer Günü Özel";
            campaign1.DiscountRate = 0.25;
            campaign1.StartDate = new DateTime(2021, 2, 14);
            campaign1.EndDate = new DateTime(2021, 2, 17);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.Delete(campaign1);

            SaleManager saleManager = new SaleManager(campaign1);
            saleManager.Sale(game1, gamer);
        }
    }
}
