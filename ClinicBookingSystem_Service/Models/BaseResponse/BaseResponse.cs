﻿using ClinicBookingSystem_Service.Models.Enums;

namespace ClinicBookingSystem_Service.Models.BaseResponse;

public class BaseResponse<T>
{
    public string Message { get; set; } = "Sucessfull";
    public StatusCodeEnum StatusCode { get; set; }
    public T Data { get; set; }
    public BaseResponse(string? message, StatusCodeEnum statusCode, T? data)
    {
        Message = message;
        StatusCode = statusCode;
        Data = data;
    }
}