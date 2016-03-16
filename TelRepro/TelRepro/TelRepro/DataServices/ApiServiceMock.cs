using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TelRepro.Models;
using Xamarin.Forms;

namespace TelRepro.DataServices
{
    public class ApiServiceMock
    {
        public static List<ActionItem> GetActionItems()
        {

            var list = new List<ActionItem>();
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 1",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 2",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 3",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 4",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 5",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 6",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 7",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 8",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 9",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 10",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 11",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 12",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 13",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 14",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 15",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 16",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 17",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 18",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 19",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 20",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 21",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 22",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 23",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 24",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 25",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 26",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 27",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            }); list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 28",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 29",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            list.Add(new ActionItem
            {
                ActionType = ActionItemType.PrebillingApproval,
                Description = "Prebilling Approval",
                Property = "Property 30",
                AcctManager = "Erik Dahl",
                AcctMgrPhone = "545-867-5309",
                AcctMgrEmail = "me@knowhere.com",
                PropSvcRep = "Weston Thomas",
                PsrPhone = "454-867-5309",
                PsrEmail = "him@knowhere.com",
                InstanceId = "12345",
                CreatedAtDt = new System.DateTime(2015, 9, 1, 17, 5, 3),
                Details = new Dictionary<string, object>()
                {
                    {"CurrentBillCount", "212" },
                    {"PreviousBillCount", "208" },
                    {"PreviousAvgNormalBill", "48.29" },
                    { "CurrentAvgNormalBill", "49.02" },
                    {"PreviousBillingAmount", "3892.04" }
                }
            });
            return list;
        }

    }
}