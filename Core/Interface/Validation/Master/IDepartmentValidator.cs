﻿using Core.DomainModel;
using Core.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Interface.Validation
{
    public interface IDepartmentValidator
    {
        Department VHasUniqueName(Department department, IDepartmentService _departmentService);

        bool ValidCreateObject(Department department, IDepartmentService _departmentService, IBranchOfficeService _branchOfficeService);
        bool ValidUpdateObject(Department department, IDepartmentService _departmentService, IBranchOfficeService _branchOfficeService);
        bool ValidDeleteObject(Department department, IDivisionService _divisionService);
        bool isValid(Department department);
        string PrintError(Department department);
    }
}