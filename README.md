## 介紹

- 透過 CRUD 練習後端 C# 語言開 webAPI

## 練習方式

- 在 routes 檔案 製作 CRUD API
- Server 部署在 Render.com 平台

## 可用以下 url 在 Postman call API

- API 部署在 Render.com 平台
  - GET API - allCharacter
    - https://c-practice.onrender.com/Character/all
  - GET API - 單一character
    - https://c-practice.onrender.com/Character/CharacterB
  - POST API
    - https://c-practice.onrender.com/Character
    - Postman body 範例可以給以下
    ```
    {
      "Id": 5,
      "Name": "CharacterE"
    }
    ```
  - DELETE API - 刪除 character
    - https://c-practice.onrender.com/Character
    - Postman body 範例可以給以下
    ```
    須先call GET API 取得想刪除的 name
    再到 Postman DELETE API的body 給id
    {
      "name": "CharacterE" //放GET API 取得想刪除的 name
    }
    ```
- locallhost
  - run 起 local project
    - dotnet run
  - GET API - allCharacter
    - http://localhost:5223/Character/all
  - GET API - 單一character
    - http://localhost:5223/Character/CharacterB
  - POST API
    - http://localhost:5223/Character
    - Postman body 範例可以給以下
    ```
    {
      "Id": 5,
      "Name": "CharacterE"
    }
    ```
  - DELETE API - 刪除 character
    - http://localhost:5223/Character
    - Postman body 範例可以給以下
    ```
    須先call GET API 取得想刪除的 name
    再到 Postman DELETE API的body 給id
    {
      "name": "CharacterE" //放GET API 取得想刪除的 name
    }
    ```
