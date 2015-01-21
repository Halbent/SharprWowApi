﻿using System;
namespace SharprWowApi
{
    interface IApiClient
    {
        string APIKey { get; set; }
        string Host { get; set; }
        Locale Locale { get; set; }
        Region Region { get; set; }

        SharprWowApi.Models.Achievement.AchievementRoot GetAchievement(int achievementId);
        SharprWowApi.Models.Quest.QuestRoot getAchievement(int questId);
        System.Threading.Tasks.Task<SharprWowApi.Models.Achievement.AchievementRoot> GetAchievementAsync(int achievementId);
        SharprWowApi.Models.DataResources.DataAchievementRoot GetAchievementsData();
        System.Threading.Tasks.Task<SharprWowApi.Models.DataResources.DataAchievementRoot> GetAchievementsDataAsync();
        SharprWowApi.Models.Auction.AuctionFilesRoot GetAuctionFile(string realm);
        SharprWowApi.Models.Auction.AuctionsRoot GetAuctions(string realm);
        System.Threading.Tasks.Task<SharprWowApi.Models.Auction.AuctionsRoot> GetAuctionsAsync(string realm);
        SharprWowApi.Models.DataResources.DataBattleGroupRoot GetBattlegroupData();
        SharprWowApi.Models.BattlePet.BattlePetAbilitiesRoot GetBattlePetAbilities(int abilityId);
        SharprWowApi.Models.BattlePet.BattlePetSpeciesRoot GetBattlePetSpecies(int speciesId);
        SharprWowApi.Models.BattlePet.BattlePetStatsRoot GetBattlePetStats(int speciesId);
        SharprWowApi.Models.ChallengeMode.ChallengeRoot GetChallengeModeLeaderboard();
        SharprWowApi.Models.ChallengeMode.ChallengeRoot GetChallengeModeLeaderboard(string realm);
        System.Threading.Tasks.Task<SharprWowApi.Models.ChallengeMode.ChallengeRoot> GetChallengeModeLeaderboardAsync();
        System.Threading.Tasks.Task<SharprWowApi.Models.ChallengeMode.ChallengeRoot> GetChallengeModeLeaderboardAsync(string realm);
        SharprWowApi.Models.Character.CharacterRoot GetCharacter(string realm, string name);
        SharprWowApi.Models.Character.CharacterRoot GetCharacter(string realm, string name, CharacterOptions characterOptions);
        System.Threading.Tasks.Task<SharprWowApi.Models.Character.CharacterRoot> GetCharacterAsync(string realm, string name, CharacterOptions characterOptions);
        SharprWowApi.Models.DataResources.DataCharacterClassesRoot GetClassData();
        SharprWowApi.Models.Guild.GuildRoot GetGuild(string realm, string name);
        SharprWowApi.Models.Guild.GuildRoot GetGuild(string realm, string name, GuildOptions realmOptions);
        SharprWowApi.Models.DataResources.DataGuildAchivementRoot GetGuildAchievementData();
        System.Threading.Tasks.Task<SharprWowApi.Models.DataResources.DataGuildAchivementRoot> GetGuildAchievementDataAsync();
        System.Threading.Tasks.Task<SharprWowApi.Models.Guild.GuildRoot> GetGuildAsync(string realm, string name, GuildOptions realmOptions);
        SharprWowApi.Models.DataResources.DataGuildPerksRoot GetGuildPerkData();
        SharprWowApi.Models.DataResources.DataGuildRewardsRoot GetGuildRewardData();
        SharprWowApi.Models.DataResources.DataItemClassRoot GetItemClassData();
        SharprWowApi.Models.PVP.LeaderboardRoot GetLeaderboard(LeaderboardOptions leaderboardOptions);
        SharprWowApi.Models.DataResources.DataPetTypesRoot GetPetTypeData();
        SharprWowApi.Models.DataResources.DataRacesRoot GetRaceData();
        SharprWowApi.Models.RealmStatus.RealmRoot GetRealmStatus();
        SharprWowApi.Models.Recipe.RecipeRoot GetRecipe(int recipeId);
        SharprWowApi.Models.Spells.SpellRoot GetSpell(int spellId);

    }
}
