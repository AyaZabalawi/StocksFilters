﻿using ServiceContracts.DTO;

namespace ServiceContracts
{
    /// <summary>
    /// Represents Stocks service that includes operations like buy order, sell order
    /// </summary>
    public interface IStocksService
    {
        /// <summary>
        /// Creates a buy order
        /// </summary>
        /// <param name="buyOrderRequest">Buy order object</param>
        Task<BuyOrderResponse> CreateBuyOrder(BuyOrderRequest? buyOrderRequest);


        /// <summary>
        /// Creates a buy order
        /// </summary>
        /// <param name="sellOrderRequest">Sell order object</param>
        Task<SellOrderResponse> CreateSellOrder(SellOrderRequest? sellOrderRequest);


        /// <summary>
        /// Returns all existing buy orders
        /// </summary>
        /// <returns>Returns a list of objects of BuyOrder type</returns>
        Task<List<BuyOrderResponse>> GetBuyOrders();


        /// <summary>
        /// Returns all existing sell orders
        /// </summary>
        /// <returns>Returns a list of objects of SellOrder type</returns>
        Task<List<SellOrderResponse>> GetSellOrders();
    }
}