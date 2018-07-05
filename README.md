simboss-csharp-sdk
---
[SIMBOSS API](https://www.simboss.com/www/api-doc/index.html) SDK

## 快速开始

- NuGet添加 simboss-csharp-sdk依赖项


- 使用SimbossClient

```java
//初始化client,所有请求使用一个clien
private static SimbossClient client = new SimbossClient("appId", "appSecret").Init();

//查询卡详情
DeviceDetailRequest request = new DeviceDetailRequest();
request.Iccid = "89860401101730528432";
SimbossResponse<DeviceDetailModel> response = client.Excute<DeviceDetailModel>(request);

//返回结果说明
//1、接口请求的是否成功
Boolean success = response.Success;
//2、返回码, 见https://www.simboss.com/www/api-doc/index.html, 返回码规范章节。
String code = response.Code;
//3、返回的成功或者错误消息
String message = response.Message;
//4、返回的成功或者错误详细消息
String detail = response.Detail;
//5、返回的数据，不同请求返回值不同，根据request.getResponseType()确定.
DeviceDetailModel data = response.Data;
//所有API使用同一个client, 不要轻易释放资源除非确定不再用了.
client.Dispose();

```

## 配置说明
- 自定义配置方式

```C#
Dictionary<String, String> dic = new Dictionary<String, String>();
//链接超时时间，单位毫秒
dic.Add("httpTimeout", "200000");
//API地址
String apiUrl = "http://api.simboss.com";
SimbossClient client = new SimbossClient("appId", "appSecret", apiUrl, dic).Init();

```

## API 清单

| API 名称               |           请求参                 |  返回值                                  |
| --------------------- | :-----------------------------: | :--------------------------------------: |
|1.1 账户总览接口         | UserDashboardGetRequest         | SimbossResponse\<DashboardDTO\>          |
|2.1 批量卡详情			 | DeviceDetailBatchRequest        | SimbossResponse\<List\<DeviceDetailDTO\>\>   |
|2.2 单卡详情				 | DeviceDetailRequest             | SimbossResponse\<DeviceDetailDTO\>         |
|2.3 单卡已订购套餐列表	 | DeviceOrderedPlansRequest       | SimbossResponse\<List\<OrderedPlansDTO\>\>   |
|2.4 单卡可续费套餐信息	 | DeviceRateplansRequest          | SimbossResponse\<List\<RatePlansDTO\>\>      |
|2.5 单卡续费				 | DeviceRechargeRequest           | SimbossResponse\<String\>                  |
|2.6 单卡续费记录			 | DeviceRechargeRecordsRequest    | SimbossResponse\<List\<RechargeRecordsDTO\>\> |
|2.7 实时连接状态查询		 | DeviceGprsStatusRequest         | SimbossResponse\<DeviceGprsStatusDTO\>     |
|2.8 实时用户状态查询		 | DeviceUserStatusRequest         | SimbossResponse\<DeviceUserStatusDTO\>     |
|2.9 设备实时开关机状态查询 | DeviceRunningStatusRequest      | SimbossResponse\<DeviceRunningStatusDTO\>  |
|2.10 查询设备套餐概要     | DeviceRatePlanSummaryRequest    | SimbossResponse\<RatePlanSummaryDTO\>      |
|2.11 流量池卡开关网络     | DeviceModifyDeviceStatusRequest | SimbossResponse\<String\>                  |
|2.12 日用量查询          | DeviceDailyUsageRequest         | SimbossResponse\<DailyUsageDTO\>           |
|2.13 取消测试期          | DeviceCancelTestingRequest      | SimbossResponse\<String\>                  |
|2.14 更新备注            | DeviceMemoUpdateRequest         | SimbossResponse\<String\>                  |
|2.15 批量更新备注         | DeviceMemoBatchUpdateRequest    | SimbossResponse\<String\>                  |
|3.1 流量池详情			 | CardPoolDetailRequest           | SimbossResponse\<CardPoolDTO\>             |
|3.2 用户下所有流量池信息   | CardPoolListRequest             | SimbossResponse\<List\<CardPoolDTO\>\>      |
|4.1 提交实名认证信息		 | RealnameSubmitRealnameRequest   | SimbossResponse\<String\>                  |
|5.1 短信下发接口			 | SmsSendRequest                  | SimbossResponse\<String\>                  |
|5.2 短信查询             | SmsListRequest                  | SimbossResponse\<SmsListDTO\>              |

## 源码说明 
- simboss-csharp-sdk(sdk) 版本说明：
 
1. NetStandard.Library 2.0.1及以上
2. Newtonsoft.Json 11.0.2及以上

- simboss-csharp-sdk-test(sdk单元测试) 版本说明：

1. Microsoft.Net.Test.Sdk 15.3.0及以上
2. xunit 2.2.0及以上
3. xunit.runner.visualstudio 2.2.0及以上
4. Microsoft.NETCore.app 2.0.0及以上




