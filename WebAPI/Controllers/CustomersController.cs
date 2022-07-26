﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
[AllowAnonymous]
public class CustomersController : ControllerBase
{
    ICustomerService _customerService;
    //IoC Container -- Inversion of Controller

    public CustomersController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet("getall")]
    public IActionResult GetAll() 
    {
        var result = _customerService.GetAll();
        if (result.Success) 
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById(int id)
    {
        var result = _customerService.GetById(id);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpGet("search")]
    public IActionResult Search(string name)
    {
        var result = _customerService.GetAllByName(name);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("add")]
    public IActionResult Add(Customer customer) 
    {
        var result = _customerService.Add(customer);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("update")]
    public IActionResult Update(Customer customer)
    {
        var result = _customerService.Update(customer);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("delete")]
    public IActionResult Delete(Customer customer)
    {
        var result = _customerService.Delete(customer);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("deletebyid")]
    public IActionResult DeleteById(int id)
    {
        var result = _customerService.SoftDelete(id);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}
