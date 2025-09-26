
# 🚀 Microservices API Gateway with Ocelot

This project demonstrates how to build a **Microservices architecture** with an **API Gateway** using the **Ocelot** library in .NET.  
It includes multiple APIs (API_1, API_2, API_3) and an API Gateway that manages routing, authentication, and authorization.  

---

## 🎯 Features
- Centralized API Gateway using **Ocelot**  
- JWT-based **Authentication & Authorization** for `API_1`  
- Simple downstream routing for `API_2` and `API_3`  
- HTTPS support with trusted developer certificates  
- Tested with **Insomnia** as the client  

---

## ⚙️ Microservices

### 🔑 API_1 - Authentication & Authorization

`API_1` is protected with **JWT tokens**.
Only valid tokens with the correct `Role` claim can access its endpoints.

<img width="1918" height="305" alt="api1 Geteway Authentication   Authorization  " src="https://github.com/user-attachments/assets/e289556e-2931-4095-9dfe-f0b545c0ad5d" />

---

### 🌐 API_2 - Public Service

`API_2` is a simple service that does not require authentication. It can be accessed directly through the gateway.


<img width="1581" height="412" alt="api2 Geteway" src="https://github.com/user-attachments/assets/be055e16-0eb9-4722-9c9a-41d0b5998fe6" />


---

### 📡 API_3 - Public Service

Similar to `API_2`, this service is open and does not enforce authentication.


<img width="1578" height="567" alt="api3 Geteway" src="https://github.com/user-attachments/assets/da6600f2-2507-4da2-83c3-ba4ebe3991f2" />


---

## 🔒 JWT Token Generation

JWT tokens were generated using an online tool with matching **Issuer, Audience, and SecurityKey** defined in the `appsettings.json`.
The token is then added to the request as a **Bearer Token** in Insomnia.

<img width="693" height="817" alt="Role-Based Security Token Key Generation" src="https://github.com/user-attachments/assets/67082a18-489f-4e64-94d7-1ad353c9c3bf" />

---

## 🧪 Example Errors

During testing, invalid or missing tokens result in proper error responses such as **401 Unauthorized**.

<img width="1587" height="387" alt="Authentication was not performed or was performed incorrectly" src="https://github.com/user-attachments/assets/515e1a6d-d83b-4a6e-8f51-c1a4534e4b42" />

---
