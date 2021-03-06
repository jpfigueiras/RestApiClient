using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client;
using SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Model;

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRoomMembershipApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Adds new member to an existing room.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>SuccessResponse</returns>
        SuccessResponse V1RoomIdMembershipAddPost (string id, UserId payload, string sessionToken);

        /// <summary>
        /// Adds new member to an existing room.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        ApiResponse<SuccessResponse> V1RoomIdMembershipAddPostWithHttpInfo (string id, UserId payload, string sessionToken);
        /// <summary>
        /// Demotes room owner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>SuccessResponse</returns>
        SuccessResponse V1RoomIdMembershipDemoteOwnerPost (string id, UserId payload, string sessionToken);

        /// <summary>
        /// Demotes room owner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        ApiResponse<SuccessResponse> V1RoomIdMembershipDemoteOwnerPostWithHttpInfo (string id, UserId payload, string sessionToken);
        /// <summary>
        /// Lists the members of an existing room.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>MembershipList</returns>
        MembershipList V1RoomIdMembershipListGet (string id, string sessionToken);

        /// <summary>
        /// Lists the members of an existing room.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of MembershipList</returns>
        ApiResponse<MembershipList> V1RoomIdMembershipListGetWithHttpInfo (string id, string sessionToken);
        /// <summary>
        /// Promotes user to owner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>SuccessResponse</returns>
        SuccessResponse V1RoomIdMembershipPromoteOwnerPost (string id, UserId payload, string sessionToken);

        /// <summary>
        /// Promotes user to owner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        ApiResponse<SuccessResponse> V1RoomIdMembershipPromoteOwnerPostWithHttpInfo (string id, UserId payload, string sessionToken);
        /// <summary>
        /// Removes member from an existing room.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>SuccessResponse</returns>
        SuccessResponse V1RoomIdMembershipRemovePost (string id, UserId payload, string sessionToken);

        /// <summary>
        /// Removes member from an existing room.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        ApiResponse<SuccessResponse> V1RoomIdMembershipRemovePostWithHttpInfo (string id, UserId payload, string sessionToken);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Adds new member to an existing room.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of SuccessResponse</returns>
        System.Threading.Tasks.Task<SuccessResponse> V1RoomIdMembershipAddPostAsync (string id, UserId payload, string sessionToken);

        /// <summary>
        /// Adds new member to an existing room.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1RoomIdMembershipAddPostAsyncWithHttpInfo (string id, UserId payload, string sessionToken);
        /// <summary>
        /// Demotes room owner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of SuccessResponse</returns>
        System.Threading.Tasks.Task<SuccessResponse> V1RoomIdMembershipDemoteOwnerPostAsync (string id, UserId payload, string sessionToken);

        /// <summary>
        /// Demotes room owner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1RoomIdMembershipDemoteOwnerPostAsyncWithHttpInfo (string id, UserId payload, string sessionToken);
        /// <summary>
        /// Lists the members of an existing room.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of MembershipList</returns>
        System.Threading.Tasks.Task<MembershipList> V1RoomIdMembershipListGetAsync (string id, string sessionToken);

        /// <summary>
        /// Lists the members of an existing room.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (MembershipList)</returns>
        System.Threading.Tasks.Task<ApiResponse<MembershipList>> V1RoomIdMembershipListGetAsyncWithHttpInfo (string id, string sessionToken);
        /// <summary>
        /// Promotes user to owner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of SuccessResponse</returns>
        System.Threading.Tasks.Task<SuccessResponse> V1RoomIdMembershipPromoteOwnerPostAsync (string id, UserId payload, string sessionToken);

        /// <summary>
        /// Promotes user to owner.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1RoomIdMembershipPromoteOwnerPostAsyncWithHttpInfo (string id, UserId payload, string sessionToken);
        /// <summary>
        /// Removes member from an existing room.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of SuccessResponse</returns>
        System.Threading.Tasks.Task<SuccessResponse> V1RoomIdMembershipRemovePostAsync (string id, UserId payload, string sessionToken);

        /// <summary>
        /// Removes member from an existing room.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1RoomIdMembershipRemovePostAsyncWithHttpInfo (string id, UserId payload, string sessionToken);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RoomMembershipApi : IRoomMembershipApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomMembershipApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RoomMembershipApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomMembershipApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RoomMembershipApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Adds new member to an existing room. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>SuccessResponse</returns>
        public SuccessResponse V1RoomIdMembershipAddPost (string id, UserId payload, string sessionToken)
        {
             ApiResponse<SuccessResponse> localVarResponse = V1RoomIdMembershipAddPostWithHttpInfo(id, payload, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Adds new member to an existing room. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        public ApiResponse< SuccessResponse > V1RoomIdMembershipAddPostWithHttpInfo (string id, UserId payload, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoomMembershipApi->V1RoomIdMembershipAddPost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling RoomMembershipApi->V1RoomIdMembershipAddPost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling RoomMembershipApi->V1RoomIdMembershipAddPost");

            var localVarPath = "/v1/room/{id}/membership/add";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipAddPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipAddPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Adds new member to an existing room. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of SuccessResponse</returns>
        public async System.Threading.Tasks.Task<SuccessResponse> V1RoomIdMembershipAddPostAsync (string id, UserId payload, string sessionToken)
        {
             ApiResponse<SuccessResponse> localVarResponse = await V1RoomIdMembershipAddPostAsyncWithHttpInfo(id, payload, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Adds new member to an existing room. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1RoomIdMembershipAddPostAsyncWithHttpInfo (string id, UserId payload, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoomMembershipApi->V1RoomIdMembershipAddPost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling RoomMembershipApi->V1RoomIdMembershipAddPost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling RoomMembershipApi->V1RoomIdMembershipAddPost");

            var localVarPath = "/v1/room/{id}/membership/add";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipAddPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipAddPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Demotes room owner. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>SuccessResponse</returns>
        public SuccessResponse V1RoomIdMembershipDemoteOwnerPost (string id, UserId payload, string sessionToken)
        {
             ApiResponse<SuccessResponse> localVarResponse = V1RoomIdMembershipDemoteOwnerPostWithHttpInfo(id, payload, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Demotes room owner. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        public ApiResponse< SuccessResponse > V1RoomIdMembershipDemoteOwnerPostWithHttpInfo (string id, UserId payload, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoomMembershipApi->V1RoomIdMembershipDemoteOwnerPost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling RoomMembershipApi->V1RoomIdMembershipDemoteOwnerPost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling RoomMembershipApi->V1RoomIdMembershipDemoteOwnerPost");

            var localVarPath = "/v1/room/{id}/membership/demoteOwner";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipDemoteOwnerPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipDemoteOwnerPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Demotes room owner. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of SuccessResponse</returns>
        public async System.Threading.Tasks.Task<SuccessResponse> V1RoomIdMembershipDemoteOwnerPostAsync (string id, UserId payload, string sessionToken)
        {
             ApiResponse<SuccessResponse> localVarResponse = await V1RoomIdMembershipDemoteOwnerPostAsyncWithHttpInfo(id, payload, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Demotes room owner. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1RoomIdMembershipDemoteOwnerPostAsyncWithHttpInfo (string id, UserId payload, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoomMembershipApi->V1RoomIdMembershipDemoteOwnerPost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling RoomMembershipApi->V1RoomIdMembershipDemoteOwnerPost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling RoomMembershipApi->V1RoomIdMembershipDemoteOwnerPost");

            var localVarPath = "/v1/room/{id}/membership/demoteOwner";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipDemoteOwnerPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipDemoteOwnerPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Lists the members of an existing room. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>MembershipList</returns>
        public MembershipList V1RoomIdMembershipListGet (string id, string sessionToken)
        {
             ApiResponse<MembershipList> localVarResponse = V1RoomIdMembershipListGetWithHttpInfo(id, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Lists the members of an existing room. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of MembershipList</returns>
        public ApiResponse< MembershipList > V1RoomIdMembershipListGetWithHttpInfo (string id, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoomMembershipApi->V1RoomIdMembershipListGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling RoomMembershipApi->V1RoomIdMembershipListGet");

            var localVarPath = "/v1/room/{id}/membership/list";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MembershipList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MembershipList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MembershipList)));
            
        }

        /// <summary>
        /// Lists the members of an existing room. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of MembershipList</returns>
        public async System.Threading.Tasks.Task<MembershipList> V1RoomIdMembershipListGetAsync (string id, string sessionToken)
        {
             ApiResponse<MembershipList> localVarResponse = await V1RoomIdMembershipListGetAsyncWithHttpInfo(id, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Lists the members of an existing room. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (MembershipList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MembershipList>> V1RoomIdMembershipListGetAsyncWithHttpInfo (string id, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoomMembershipApi->V1RoomIdMembershipListGet");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling RoomMembershipApi->V1RoomIdMembershipListGet");

            var localVarPath = "/v1/room/{id}/membership/list";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipListGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipListGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MembershipList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MembershipList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MembershipList)));
            
        }

        /// <summary>
        /// Promotes user to owner. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>SuccessResponse</returns>
        public SuccessResponse V1RoomIdMembershipPromoteOwnerPost (string id, UserId payload, string sessionToken)
        {
             ApiResponse<SuccessResponse> localVarResponse = V1RoomIdMembershipPromoteOwnerPostWithHttpInfo(id, payload, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Promotes user to owner. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        public ApiResponse< SuccessResponse > V1RoomIdMembershipPromoteOwnerPostWithHttpInfo (string id, UserId payload, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoomMembershipApi->V1RoomIdMembershipPromoteOwnerPost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling RoomMembershipApi->V1RoomIdMembershipPromoteOwnerPost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling RoomMembershipApi->V1RoomIdMembershipPromoteOwnerPost");

            var localVarPath = "/v1/room/{id}/membership/promoteOwner";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipPromoteOwnerPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipPromoteOwnerPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Promotes user to owner. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of SuccessResponse</returns>
        public async System.Threading.Tasks.Task<SuccessResponse> V1RoomIdMembershipPromoteOwnerPostAsync (string id, UserId payload, string sessionToken)
        {
             ApiResponse<SuccessResponse> localVarResponse = await V1RoomIdMembershipPromoteOwnerPostAsyncWithHttpInfo(id, payload, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Promotes user to owner. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1RoomIdMembershipPromoteOwnerPostAsyncWithHttpInfo (string id, UserId payload, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoomMembershipApi->V1RoomIdMembershipPromoteOwnerPost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling RoomMembershipApi->V1RoomIdMembershipPromoteOwnerPost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling RoomMembershipApi->V1RoomIdMembershipPromoteOwnerPost");

            var localVarPath = "/v1/room/{id}/membership/promoteOwner";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipPromoteOwnerPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipPromoteOwnerPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Removes member from an existing room. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>SuccessResponse</returns>
        public SuccessResponse V1RoomIdMembershipRemovePost (string id, UserId payload, string sessionToken)
        {
             ApiResponse<SuccessResponse> localVarResponse = V1RoomIdMembershipRemovePostWithHttpInfo(id, payload, sessionToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Removes member from an existing room. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>ApiResponse of SuccessResponse</returns>
        public ApiResponse< SuccessResponse > V1RoomIdMembershipRemovePostWithHttpInfo (string id, UserId payload, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoomMembershipApi->V1RoomIdMembershipRemovePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling RoomMembershipApi->V1RoomIdMembershipRemovePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling RoomMembershipApi->V1RoomIdMembershipRemovePost");

            var localVarPath = "/v1/room/{id}/membership/remove";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipRemovePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipRemovePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

        /// <summary>
        /// Removes member from an existing room. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of SuccessResponse</returns>
        public async System.Threading.Tasks.Task<SuccessResponse> V1RoomIdMembershipRemovePostAsync (string id, UserId payload, string sessionToken)
        {
             ApiResponse<SuccessResponse> localVarResponse = await V1RoomIdMembershipRemovePostAsyncWithHttpInfo(id, payload, sessionToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Removes member from an existing room. 
        /// </summary>
        /// <exception cref="SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Room streamId</param>
        /// <param name="payload"></param>
        /// <param name="sessionToken">Session authentication token.</param>
        /// <returns>Task of ApiResponse (SuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SuccessResponse>> V1RoomIdMembershipRemovePostAsyncWithHttpInfo (string id, UserId payload, string sessionToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RoomMembershipApi->V1RoomIdMembershipRemovePost");
            // verify the required parameter 'payload' is set
            if (payload == null)
                throw new ApiException(400, "Missing required parameter 'payload' when calling RoomMembershipApi->V1RoomIdMembershipRemovePost");
            // verify the required parameter 'sessionToken' is set
            if (sessionToken == null)
                throw new ApiException(400, "Missing required parameter 'sessionToken' when calling RoomMembershipApi->V1RoomIdMembershipRemovePost");

            var localVarPath = "/v1/room/{id}/membership/remove";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (sessionToken != null) localVarHeaderParams.Add("sessionToken", Configuration.ApiClient.ParameterToString(sessionToken)); // header parameter
            if (payload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(payload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = payload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipRemovePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling V1RoomIdMembershipRemovePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SuccessResponse)));
            
        }

    }
}
