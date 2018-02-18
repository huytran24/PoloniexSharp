<img src="https://raw.githubusercontent.com/skuvnar/PoloniexSharp/master/poloniex.jpg" alt="Poloniex logo" width="90" />

# PoloniexSharp
.NET library to access the Poloniex crypto currency exchange REST API. Currently supports .NET 4.5+. Support for .NET Standard 1.2+, .NET Core 1.0+ coming soon in the next iterations.

## Install via NuGet

You can install this through `nuget.org` through the command line or by Package Manager.

To install it with `Package Manager`

```
> Install-Package PoloniexSharp
```

To install by command line:

```
nuget install PoloniexSharp
```

## Usage

Using this library you can access Poloniex's public API and the authenticated trading API. The library was intended to be intuitive and easy to use. All actions can be discovered through the `PoloniexService` class. For example, to get the current ticker, we do the following:

```csharp
var service = new PoloniexService();
var response = service.GetTicker();
```

This results in a collection of tickers (`TickerDetails`) for each currency pair (for example bitcoin and ethereum : BTC_ETH):

```csharp
public class TickerDetails
{
  public int Id { get; set; }
  public string CurrencyPair { get; set; }
  public double Last { get; set; }
  public double LowestAsk { get; set; }
  public double HighestBid { get; set; }
  public double PercentChange { get; set; }
  public double BaseVolume { get; set; }
  public double QuoteVolume { get; set; }
  public string IsFrozen { get; set; }
  public double High24hr { get; set; }
  public double Low24hr { get; set; }
}
```

## Supported functions
Poloniex contains three types of API functions: Public API, Push API and Trading API. Below are the functions this library supports.

### Public functions
* GetTicker
* Get24hrVolume
* GetOrderBook
* GetTradeHistory
