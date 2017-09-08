# ChannelEngine.Api.Client.Model.ChannelProcessedChangesRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Created** | [**List&lt;ChannelReferencesRequest&gt;**](ChannelReferencesRequest.md) | A collection of pairs of merchant and channel references  of the products which are successfully created. The channel references  are saved such that in subsequent calls these can be used instead of the   merchant references. | [optional] 
**Updated** | **List&lt;string&gt;** | The channel references of the products which are successfully updated. | [optional] 
**Removed** | **List&lt;string&gt;** | The channel references of the products which are successfully removed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

