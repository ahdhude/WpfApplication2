Imports System.Globalization
Namespace WpfApplication2.Domain
    Public Class NotEmptyValidationRule
        Inherits ValidationRule
        Public Overrides Function Validate(value As Object, cultureInfo As CultureInfo) As ValidationResult
            Return If(String.IsNullOrWhiteSpace((If(value, "")).ToString()), New ValidationResult(False, "Field is required."), ValidationResult.ValidResult)
        End Function
    End Class
End Namespace
