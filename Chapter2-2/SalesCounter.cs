// Code 2-21
using System.Collections.Generic;

namespace SalesCalculator;

// Code 2-16
// 売り上げ集計クラス
public class SalesCounter
{

    private readonly List<Sale> _sales;

    // コンストラクタ
    public SalesCounter(List<Sale> sales)
    {
        _sales = sales;
    }

    // Code 2-17
    // 店舗別売り上げを求める
    public Dictionary<string, int> GetPerStoreSales()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach (Sale sale in _sales)
        {
            if (dict.ContainsKey(sale.ShopName))
                dict[sale.ShopName] += sale.Amount;
            else
                dict[sale.ShopName] = sale.Amount;
        }
        return dict;
    }
    // Code 2-15
    // 売り上げデータを読み込み、Saleオブジェクトのリストを返す
    private static List<Sale> ReadSales(string filePath)
    {
        List<Sale> sales = new List<Sale>();
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] items = line.Split(',');
            Sale sale = new Sale
            {    //- オブジェクト初期化子を使ってプロパティを初期化
                ShopName = items[0],
                ProductCategory = items[1],
                Amount = int.Parse(items[2])
            };
            sales.Add(sale);
        }
        return sales;
    }
}

