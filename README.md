# Weather forecast from US (API version)

API like proxy to make requests from [National Weather Service](https://www.weather.gov/documentation/services-web-api) throught [Geocoding Services](https://geocoding.geo.census.gov/geocoder/Geocoding_Services_API.pdf) as latitude and longitude params points from postal code address. 

The API wotks together with Web/Client side version developed in React [here](https://github.com/gabrielfreirebraz/weather-forecast-web). 

## Technologies 

- ASP.NET Core 8
- C#

## Preview

[Click here to preview](https://drive.google.com/file/d/1emEgPfk3k2JykrxCnAk7gl_KYRrVkzmY/view?usp=sharing)
![Project image](https://lh3.googleusercontent.com/u/0/drive-viewer/AEYmBYTqrRTpv3F71FvdPjRgBP8hUXj-1Ja8tLrAIectleRZ4k4bVnKir0hajDpTQMEkDdNJhf628McLgP7Ffum1tsj_nKTm=w1353-h968)

## Endpoints

How to make web request and response from API Rest

### GET: /api/geocoding

Example **query params to request**:

Curl:
`
curl -X 'GET' \
  'http://localhost:5149/api/geocoding?address=75%203rd%20Ave%2C%20New%20York%2C%20NY%2010003%2C%20USA' \
  -H 'accept: application/json'
`

Axios:
```js
const request = await axios.get("http://localhost:5149/api/geocoding", {
        params: { address: "75 3rd Ave, New York, NY 10003, USA" }
    }
);
console.log(request.data);
```

Example **json to response**:

```json
{
    "result": {
        "input": {
            "address": {
                "address": "75 3rd Ave, New York, NY 10003, USA"
            },
            "benchmark": {
                "isDefault": false,
                "benchmarkDescription": "Public Address Ranges - Census 2020 Benchmark",
                "id": "2020",
                "benchmarkName": "Public_AR_Census2020"
            }
        },
        "addressMatches": [
            {
                "tigerLine": {
                    "side": "R",
                    "tigerLineId": "59653705"
                },
                "coordinates": {
                    "x": -73.98833696287879,
                    "y": 40.73158525127099
                },
                "addressComponents": {
                    "zip": "10003",
                    "streetName": "3RD",
                    "preType": "",
                    "city": "NEW YORK",
                    "preDirection": "",
                    "suffixDirection": "",
                    "fromAddress": "67",
                    "state": "NY",
                    "suffixType": "AVE",
                    "toAddress": "85",
                    "suffixQualifier": "",
                    "preQualifier": ""
                },
                "matchedAddress": "75 3RD AVE, NEW YORK, NY, 10003"
            }
        ]
    }
}
```

### GET: /api/coordinates

Example **query params to request**:

Curl:
`
curl -X 'GET' \
  'http://localhost:5149/api/coordinates?latitude=40.73158525127099&longitude=-73.98833696287879' \
  -H 'accept: application/json'
`

Axios:
```js
const request = axios.get("http://localhost:5149/api/coordinates", {
    params: {
        latitude: 40.73158525127099,
        longitude: -73.98833696287879
    }
});
console.log(request.data);
```

Example **json to response**:

```json
{
    "@context": [
        "https://geojson.org/geojson-ld/geojson-context.jsonld",
        {
            "@version": "1.1",
            "wx": "https://api.weather.gov/ontology#",
            "s": "https://schema.org/",
            "geo": "http://www.opengis.net/ont/geosparql#",
            "unit": "http://codes.wmo.int/common/unit/",
            "@vocab": "https://api.weather.gov/ontology#",
            "geometry": {
                "@id": "s:GeoCoordinates",
                "@type": "geo:wktLiteral"
            },
            "city": "s:addressLocality",
            "state": "s:addressRegion",
            "distance": {
                "@id": "s:Distance",
                "@type": "s:QuantitativeValue"
            },
            "bearing": {
                "@type": "s:QuantitativeValue"
            },
            "value": {
                "@id": "s:value"
            },
            "unitCode": {
                "@id": "s:unitCode",
                "@type": "@id"
            },
            "forecastOffice": {
                "@type": "@id"
            },
            "forecastGridData": {
                "@type": "@id"
            },
            "publicZone": {
                "@type": "@id"
            },
            "county": {
                "@type": "@id"
            }
        }
    ],
    "id": "https://api.weather.gov/points/40.7316,-73.9883",
    "type": "Feature",
    "geometry": {
        "type": "Point",
        "coordinates": [
            -73.988299999999995,
            40.7316
        ]
    },
    "properties": {
        "@id": "https://api.weather.gov/points/40.7316,-73.9883",
        "@type": "wx:Point",
        "cwa": "OKX",
        "forecastOffice": "https://api.weather.gov/offices/OKX",
        "gridId": "OKX",
        "gridX": 34,
        "gridY": 36,
        "forecast": "https://api.weather.gov/gridpoints/OKX/34,36/forecast",
        "forecastHourly": "https://api.weather.gov/gridpoints/OKX/34,36/forecast/hourly",
        "forecastGridData": "https://api.weather.gov/gridpoints/OKX/34,36",
        "observationStations": "https://api.weather.gov/gridpoints/OKX/34,36/stations",
        "relativeLocation": {
            "type": "Feature",
            "geometry": {
                "type": "Point",
                "coordinates": [
                    -74.0279259,
                    40.745251000000003
                ]
            },
            "properties": {
                "city": "Hoboken",
                "state": "NJ",
                "distance": {
                    "unitCode": "wmoUnit:m",
                    "value": 3667.4416203175001
                },
                "bearing": {
                    "unitCode": "wmoUnit:degree_(angle)",
                    "value": 114
                }
            }
        },
        "forecastZone": "https://api.weather.gov/zones/forecast/NYZ072",
        "county": "https://api.weather.gov/zones/county/NYC061",
        "fireWeatherZone": "https://api.weather.gov/zones/fire/NYZ212",
        "timeZone": "America/New_York",
        "radarStation": "KDIX"
    }
}
```
