# webapi2_demo_1
Demo de como usar webapi2+jtoken

URLs

>GET

>http://localhost:9000/api/user/123/extrainfo

```sh
{
  "Id": 1,
  "Address": "test address",
  "Email": "test@test.com",
  "SSN": 1234567890
}
```

>PATCH

>http://localhost:9000/api/user/123/extrainfo

```sh
{
    "address":"new test address"
}
```
