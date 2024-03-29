﻿using System.Collections.Generic;
using System.ServiceModel;
using Views.BusinessProcesses.Purchase;
using Views.BusinessProcesses.Sales.Offer;

namespace Views.BusinessProcesses.Sales
{
    [ServiceContract]
    public interface IQuattroService
    {
        [OperationContract]
        void AddHeaderSales(ISalesHeaderView view);
    
        [OperationContract]
        void DeleteSalesHeader(ISalesHeaderView view);        
        
        [OperationContract]
        void AddSalesPosition(ISalesItem item);
        
        [OperationContract]
        void DeleteSalesPosition(ISalesItem item);
        
        [OperationContract]
        ISalesHeaderView QuattroSalesByPrimaryKey(int primaryKey);

        [OperationContract]
        IList<ISalesHeaderView> AllSales();

        [OperationContract]
        IList<ISalesHeaderView> BySpecifiedType(int? type);

        [OperationContract]
        IList<ISalesItem> AllSalesItemsBySalesHeader(int primaryKey);

        [OperationContract]
        void AddPurchaseHeader(IPurchaseHeaderView view);

        [OperationContract]
        void AddPuchaseItem(IPurchaseItem item);

        [OperationContract]
        void DeletePurchaseHeader(IPurchaseHeaderView view);

        [OperationContract]
        void DeletePurchaseItem(IPurchaseItem item);

        [OperationContract]
        IPurchaseHeaderView QuattroPurchaseByPrimaryKey(int primaryKey);

        [OperationContract]
        IList<IPurchaseHeaderView> AllPurchaseHeader();

        [OperationContract]
        IList<IPurchaseHeaderView> AllPurchaseHeaderBySpecifiedType(int? type);

        [OperationContract]
        IList<IPurchaseItem> AllPurchaseItemsByHeaderPrimaryKey(int primaryKey);

        [OperationContract]
        void UpdatePurchaseHeader(IPurchaseHeaderView purchaseHeader);
    }
}
