﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GreenApron
{
    public interface IAPIservice
    {
        Task<JsonResponse> AddPlan(PlanRequest plan);
        Task<JsonResponse> AddBookmark(BookmarkRequest bookmark);
        Task<BookmarkResponse> GetBookmarks();
        Task<GroceryResponse> GetGroceryItems();
        Task<JsonResponse> UpdateGroceryItems(GroceryRequest request);
        Task<InventoryResponse> GetInventoryItems();
        Task<PlanResponse> GetActivePlans();
        Task<JsonResponse> CompletePlan(Guid planId);
        Task<JsonResponse> AddInventoryItem(Ingredient item);
        Task<JsonResponse> AddGroceryItem(Ingredient item);
        Task<JsonResponse> UpdateInventoryItems(InventoryRequest request);
        Task<JsonResponse> DeleteInventoryItem(Guid inventoryItemId);
        Task<JsonResponse> DeleteGroceryItem(Guid groceryItemId);
    }
}