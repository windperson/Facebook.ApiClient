﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FacebookApi.ApiEngine;
using FacebookApi.Entities.ApiEngine;

namespace FacebookApi.Interfaces.IApiEngine
{
    /// <summary>
    /// Represents paged API response
    /// </summary>
    /// <typeparam name="TApiEntity">Entity class which can be used to represent received API response</typeparam>
    public interface IPagedResponse<TApiEntity> where TApiEntity : class, new()
    {
        /// <summary>
        /// Get next page data from API
        /// </summary>
        /// <returns>Next page data</returns>
        IPagedResponse<TApiEntity> GetNextPageData();

        /// <summary>
        /// Get next page data from API
        /// </summary>
        /// <returns>Next page data</returns>
        Task<IPagedResponse<TApiEntity>> GetNextPageDataAsync();

        /// <summary>
        /// Get previous page data from API
        /// </summary>
        /// <returns>Previous page data</returns>
        IPagedResponse<TApiEntity> GetPreviousPageData();

        /// <summary>
        /// Get previous page data from API
        /// </summary>
        /// <returns>Previous page data</returns>
        Task<IPagedResponse<TApiEntity>> GetPreviousPageDataAsync();

        /// <summary>
        /// Get API response data
        /// </summary>
        /// <returns>API response data</returns>
        IEnumerable<TApiEntity> GetResultData();

        /// <summary>
        /// Check if next page data is available or not
        /// </summary>
        /// <returns>True of <see cref="Paging.Next"/> is not null</returns>
        bool IsNextPageDataAvailable();

        /// <summary>
        /// Check if previous page data is available or not
        /// </summary>
        /// <returns>True of <see cref="Paging.Previous"/> is not null</returns>
        bool IsPreviousPageDataAvailable();

        /// <summary>
        /// Get next page url
        /// </summary>
        /// <returns>Next data page url</returns>
        string GetNextPageUrl();

        /// <summary>
        /// Checks if API has returned any data or not
        /// </summary>
        /// <returns>True if data is available</returns>
        bool IsDataAvailable();

        /// <summary>
        /// Get list of exceptions from API response.
        /// </summary>
        /// <returns>List of exceptions</returns>
        IEnumerable<Exception> GetExceptions();
    }
}