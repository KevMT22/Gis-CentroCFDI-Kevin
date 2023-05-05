

using API.Enums;
using API.Enums.CartaPorteEnums;
using System.ComponentModel;
using System.Xml.Serialization;

 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
[System.Xml.Serialization.XmlRootAttribute("Comprobante",Namespace ="http://www.sat.gob.mx/cfd/4", IsNullable=false)]
public partial class ComprobanteCFDI {
    
    private ComprobanteInformacionGlobal informacionGlobalField;
    
    private ComprobanteCfdiRelacionados[] cfdiRelacionadosField;
    
    private ComprobanteEmisor emisorField;
    
    private ComprobanteReceptor receptorField;
    
    private ComprobanteConcepto[] conceptosField;
    
    private ComprobanteImpuestos impuestosField;
    
    private ComprobanteComplemento complementoField;
    
    private ComprobanteAddenda addendaField;
    
    private string versionField;
    
    private string serieField;
    
    private string folioField;
    
    private string fechaField;
    
    private string selloField;
    
    private string formaPagoField;
    
    private bool formaPagoFieldSpecified;
    
    private string noCertificadoField;
    
    private string certificadoField;
    
    private string condicionesDePagoField;
    
    private decimal subTotalField;
    
    private decimal descuentoField;
    
    private bool descuentoFieldSpecified;
    
    private c_Moneda monedaField;
    
    private decimal tipoCambioField;
    
    private bool tipoCambioFieldSpecified;
    
    private decimal totalField;
    
    private c_TipoDeComprobante tipoDeComprobanteField;
    
    private string exportacionField;
    
    private c_MetodoPago metodoPagoField;
    
    private bool metodoPagoFieldSpecified;
    
    private string lugarExpedicionField;
    
    private string confirmacionField;

    public TimbreFiscalDigital TimbreFiscalDigital;

    public CartaPorte CartaPorte;

    public Pagos Pagos;

    public string CodigoQR;

    public string Logo;

    public ComprobanteCFDI() {
        this.versionField = "4.0";
    }
    
    /// <remarks/>
    public ComprobanteInformacionGlobal InformacionGlobal {
        get {
            return this.informacionGlobalField;
        }
        set {
            this.informacionGlobalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CfdiRelacionados")]
    public ComprobanteCfdiRelacionados[] CfdiRelacionados {
        get {
            return this.cfdiRelacionadosField;
        }
        set {
            this.cfdiRelacionadosField = value;
        }
    }
    
    /// <remarks/>
    public ComprobanteEmisor Emisor {
        get {
            return this.emisorField;
        }
        set {
            this.emisorField = value;
        }
    }
    
    /// <remarks/>
    public ComprobanteReceptor Receptor {
        get {
            return this.receptorField;
        }
        set {
            this.receptorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Concepto", IsNullable=false)]
    public ComprobanteConcepto[] Conceptos {
        get {
            return this.conceptosField;
        }
        set {
            this.conceptosField = value;
        }
    }
    
    /// <remarks/>
    public ComprobanteImpuestos Impuestos {
        get {
            return this.impuestosField;
        }
        set {
            this.impuestosField = value;
        }
    }
    
    /// <remarks/>
    public ComprobanteComplemento Complemento {
        get {
            return this.complementoField;
        }
        set {
            this.complementoField = value;
        }
    }
    
    /// <remarks/>
    public ComprobanteAddenda Addenda {
        get {
            return this.addendaField;
        }
        set {
            this.addendaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Serie {
        get {
            return this.serieField;
        }
        set {
            this.serieField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Folio {
        get {
            return this.folioField;
        }
        set {
            this.folioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Fecha {
        get {
            return this.fechaField;
        }
        set {
            this.fechaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Sello {
        get {
            return this.selloField;
        }
        set {
            this.selloField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FormaPago {
        get {
            return this.formaPagoField;
        }
        set {
            this.formaPagoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool FormaPagoSpecified {
        get {
            return this.formaPagoFieldSpecified;
        }
        set {
            this.formaPagoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NoCertificado {
        get {
            return this.noCertificadoField;
        }
        set {
            this.noCertificadoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Certificado {
        get {
            return this.certificadoField;
        }
        set {
            this.certificadoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string CondicionesDePago {
        get {
            return this.condicionesDePagoField;
        }
        set {
            this.condicionesDePagoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal SubTotal {
        get {
            return this.subTotalField;
        }
        set {
            this.subTotalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Descuento {
        get {
            return this.descuentoField;
        }
        set {
            this.descuentoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DescuentoSpecified {
        get {
            return this.descuentoFieldSpecified;
        }
        set {
            this.descuentoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_Moneda Moneda {
        get {
            return this.monedaField;
        }
        set {
            this.monedaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TipoCambio {
        get {
            return this.tipoCambioField;
        }
        set {
            this.tipoCambioField = value;
        }
    }
    
    /// <remarks/>
  /*  [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TipoCambioSpecified {
        get {
            return this.tipoCambioFieldSpecified;
        }
        set {
            this.tipoCambioFieldSpecified = value;
        }
    }*/
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Total {
        get {
            return this.totalField;
        }
        set {
            this.totalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_TipoDeComprobante TipoDeComprobante {
        get {
            return this.tipoDeComprobanteField;
        }
        set {
            this.tipoDeComprobanteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Exportacion {
        get {
            return this.exportacionField;
        }
        set {
            this.exportacionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_MetodoPago MetodoPago {
        get {
            return this.metodoPagoField;
        }
        set {
            this.metodoPagoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool MetodoPagoSpecified {
        get {
            return this.metodoPagoFieldSpecified;
        }
        set {
            this.metodoPagoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string LugarExpedicion {
        get {
            return this.lugarExpedicionField;
        }
        set {
            this.lugarExpedicionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Confirmacion {
        get {
            return this.confirmacionField;
        }
        set {
            this.confirmacionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteInformacionGlobal {
    
    private c_Periodicidad periodicidadField;
    
    private c_Meses mesesField;
    
    private short a�oField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_Periodicidad Periodicidad {
        get {
            return this.periodicidadField;
        }
        set {
            this.periodicidadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_Meses Meses {
        get {
            return this.mesesField;
        }
        set {
            this.mesesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public short A�o {
        get {
            return this.a�oField;
        }
        set {
            this.a�oField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
public enum c_Periodicidad {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("01")]
    Item01,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("02")]
    Item02,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("03")]
    Item03,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("04")]
    Item04,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("05")]
    Item05,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
public enum c_Meses {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("01")]
    Item01,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("02")]
    Item02,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("03")]
    Item03,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("04")]
    Item04,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("05")]
    Item05,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("06")]
    Item06,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("07")]
    Item07,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("08")]
    Item08,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("09")]
    Item09,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("10")]
    Item10,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("11")]
    Item11,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("12")]
    Item12,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("13")]
    Item13,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("14")]
    Item14,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("15")]
    Item15,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("16")]
    Item16,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("17")]
    Item17,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("18")]
    Item18,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteCfdiRelacionados {
    
    private ComprobanteCfdiRelacionadosCfdiRelacionado[] cfdiRelacionadoField;
    
    private string tipoRelacionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CfdiRelacionado")]
    public ComprobanteCfdiRelacionadosCfdiRelacionado[] CfdiRelacionado {
        get {
            return this.cfdiRelacionadoField;
        }
        set {
            this.cfdiRelacionadoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TipoRelacion {
        get {
            return this.tipoRelacionField;
        }
        set {
            this.tipoRelacionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteCfdiRelacionadosCfdiRelacionado {
    
    private string uUIDField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UUID {
        get {
            return this.uUIDField;
        }
        set {
            this.uUIDField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
public enum c_TipoRelacion {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("01")]
    Item01,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("02")]
    Item02,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("03")]
    Item03,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("04")]
    Item04,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("05")]
    Item05,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("06")]
    Item06,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("07")]
    Item07,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("08")]
    Item08,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("09")]
    Item09,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteEmisor {
    
    private string rfcField;
    
    private string nombreField;
    
    private c_RegimenFiscal regimenFiscalField;
    
    private string facAtrAdquirenteField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Rfc {
        get {
            return this.rfcField;
        }
        set {
            this.rfcField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Nombre {
        get {
            return this.nombreField;
        }
        set {
            this.nombreField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_RegimenFiscal RegimenFiscal {
        get {
            return this.regimenFiscalField;
        }
        set {
            this.regimenFiscalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FacAtrAdquirente {
        get {
            return this.facAtrAdquirenteField;
        }
        set {
            this.facAtrAdquirenteField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
public enum c_RegimenFiscal {

    /// <remarks/>
    [DescriptionAttribute("601-General de Ley Personas Morales")]
    [System.Xml.Serialization.XmlEnumAttribute("601")]
    Item601 = 601,

    [DescriptionAttribute("603-Personas Morales con Fines no Lucrativos")]
    [System.Xml.Serialization.XmlEnumAttribute("603")]
    Item603=603,

    [DescriptionAttribute("605-Sueldos y Salarios e Ingresos Asimilados a Salarios")]
    [System.Xml.Serialization.XmlEnumAttribute("605")]
    Item605 = 605,

    [DescriptionAttribute("606-Arrendamiento")]
    [System.Xml.Serialization.XmlEnumAttribute("606")]
    Item606 = 606,

    [DescriptionAttribute("607-R�gimen de Enajenaci�n o Adquisici�n de Bienes")]
    [System.Xml.Serialization.XmlEnumAttribute("607")]
    Item607=607,

    [DescriptionAttribute("608-Dem�s ingresos")]
    [System.Xml.Serialization.XmlEnumAttribute("608")]
    Item608=608,

    [DescriptionAttribute("610-Residentes en el Extranjero sin Establecimiento Permanente en M�xico")]
    [System.Xml.Serialization.XmlEnumAttribute("610")]
    Item610=610,

    [DescriptionAttribute("611-Ingresos por Dividendos (socios y accionistas)")]
    [System.Xml.Serialization.XmlEnumAttribute("611")]
    Item611=611,

    [DescriptionAttribute("612-Personas F�sicas con Actividades Empresariales y Profesionales")]
    [System.Xml.Serialization.XmlEnumAttribute("612")]
    Item612=612,

    [DescriptionAttribute("614-Ingresos por intereses")]
    [System.Xml.Serialization.XmlEnumAttribute("614")]
    Item614=614,

    [DescriptionAttribute("615-R�gimen de los ingresos por obtenci�n de premios")]
    [System.Xml.Serialization.XmlEnumAttribute("615")]
    Item615=615,

    [DescriptionAttribute("616-Sin obligaciones fiscales")]
    [System.Xml.Serialization.XmlEnumAttribute("616")]
    Item616=616,

    [DescriptionAttribute("620-Sociedades Cooperativas de Producci�n que optan por diferir sus ingresos")]
    [System.Xml.Serialization.XmlEnumAttribute("620")]
    Item620=620,

    [DescriptionAttribute("621-Incorporaci�n Fiscal")]
    [System.Xml.Serialization.XmlEnumAttribute("621")]
    Item621=621,

    [DescriptionAttribute("622-Actividades Agr�colas, Ganaderas, Silv�colas y Pesqueras")]
    [System.Xml.Serialization.XmlEnumAttribute("622")]
    Item622=622,

    [DescriptionAttribute("623-Opcional para Grupos de Sociedades")]
    [System.Xml.Serialization.XmlEnumAttribute("623")]
    Item623=623,

    [DescriptionAttribute("624-Coordinados")]
    [System.Xml.Serialization.XmlEnumAttribute("624")]
    Item624=624,

    [DescriptionAttribute("625-R�gimen de las Actividades Empresariales con ingresos a trav�s de Plataformas Tecnol�gicas")]
    [System.Xml.Serialization.XmlEnumAttribute("625")]
    Item625=625,
    
    [DescriptionAttribute("626-R�gimen Simplificado de Confianza")]
    [System.Xml.Serialization.XmlEnumAttribute("626")]
    Item626=626,

    /// <remarks/>
    [DescriptionAttribute("628-Hidrocarburos")]
    [System.Xml.Serialization.XmlEnumAttribute("628")]
    Item628=628,

    /// <remarks/>
    [DescriptionAttribute("629-De los Reg�menes Fiscales Preferentes y de las Empresas Multinacionales")]
    [System.Xml.Serialization.XmlEnumAttribute("629")]
    Item629=629,

    /// <remarks/>
    [DescriptionAttribute("630-Enajenaci�n de acciones en bolsa de valores")]
    [System.Xml.Serialization.XmlEnumAttribute("630")]
    Item630=630,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteReceptor {
    
    private string rfcField;
    
    private string nombreField;
    
    private string domicilioFiscalReceptorField;
    
    private c_Pais residenciaFiscalField;
    
    private bool residenciaFiscalFieldSpecified;
    
    private string numRegIdTribField;
    
    private c_RegimenFiscal regimenFiscalReceptorField;
    
    private c_UsoCfdiCP usoCFDIField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Rfc {
        get {
            return this.rfcField;
        }
        set {
            this.rfcField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Nombre {
        get {
            return this.nombreField;
        }
        set {
            this.nombreField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DomicilioFiscalReceptor {
        get {
            return this.domicilioFiscalReceptorField;
        }
        set {
            this.domicilioFiscalReceptorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_Pais ResidenciaFiscal {
        get {
            return this.residenciaFiscalField;
        }
        set {
            this.residenciaFiscalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ResidenciaFiscalSpecified {
        get {
            return this.residenciaFiscalFieldSpecified;
        }
        set {
            this.residenciaFiscalFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NumRegIdTrib {
        get {
            return this.numRegIdTribField;
        }
        set {
            this.numRegIdTribField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_RegimenFiscal RegimenFiscalReceptor {
        get {
            return this.regimenFiscalReceptorField;
        }
        set {
            this.regimenFiscalReceptorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_UsoCfdiCP UsoCFDI {
        get {
            return this.usoCFDIField;
        }
        set {
            this.usoCFDIField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
public enum c_Pais {
    
    /// <remarks/>
    AFG,
    
    /// <remarks/>
    ALA,
    
    /// <remarks/>
    ALB,
    
    /// <remarks/>
    DEU,
    
    /// <remarks/>
    AND,
    
    /// <remarks/>
    AGO,
    
    /// <remarks/>
    AIA,
    
    /// <remarks/>
    ATA,
    
    /// <remarks/>
    ATG,
    
    /// <remarks/>
    SAU,
    
    /// <remarks/>
    DZA,
    
    /// <remarks/>
    ARG,
    
    /// <remarks/>
    ARM,
    
    /// <remarks/>
    ABW,
    
    /// <remarks/>
    AUS,
    
    /// <remarks/>
    AUT,
    
    /// <remarks/>
    AZE,
    
    /// <remarks/>
    BHS,
    
    /// <remarks/>
    BGD,
    
    /// <remarks/>
    BRB,
    
    /// <remarks/>
    BHR,
    
    /// <remarks/>
    BEL,
    
    /// <remarks/>
    BLZ,
    
    /// <remarks/>
    BEN,
    
    /// <remarks/>
    BMU,
    
    /// <remarks/>
    BLR,
    
    /// <remarks/>
    MMR,
    
    /// <remarks/>
    BOL,
    
    /// <remarks/>
    BIH,
    
    /// <remarks/>
    BWA,
    
    /// <remarks/>
    BRA,
    
    /// <remarks/>
    BRN,
    
    /// <remarks/>
    BGR,
    
    /// <remarks/>
    BFA,
    
    /// <remarks/>
    BDI,
    
    /// <remarks/>
    BTN,
    
    /// <remarks/>
    CPV,
    
    /// <remarks/>
    KHM,
    
    /// <remarks/>
    CMR,
    
    /// <remarks/>
    CAN,
    
    /// <remarks/>
    QAT,
    
    /// <remarks/>
    BES,
    
    /// <remarks/>
    TCD,
    
    /// <remarks/>
    CHL,
    
    /// <remarks/>
    CHN,
    
    /// <remarks/>
    CYP,
    
    /// <remarks/>
    COL,
    
    /// <remarks/>
    COM,
    
    /// <remarks/>
    PRK,
    
    /// <remarks/>
    KOR,
    
    /// <remarks/>
    CIV,
    
    /// <remarks/>
    CRI,
    
    /// <remarks/>
    HRV,
    
    /// <remarks/>
    CUB,
    
    /// <remarks/>
    CUW,
    
    /// <remarks/>
    DNK,
    
    /// <remarks/>
    DMA,
    
    /// <remarks/>
    ECU,
    
    /// <remarks/>
    EGY,
    
    /// <remarks/>
    SLV,
    
    /// <remarks/>
    ARE,
    
    /// <remarks/>
    ERI,
    
    /// <remarks/>
    SVK,
    
    /// <remarks/>
    SVN,
    
    /// <remarks/>
    ESP,
    
    /// <remarks/>
    USA,
    
    /// <remarks/>
    EST,
    
    /// <remarks/>
    ETH,
    
    /// <remarks/>
    PHL,
    
    /// <remarks/>
    FIN,
    
    /// <remarks/>
    FJI,
    
    /// <remarks/>
    FRA,
    
    /// <remarks/>
    GAB,
    
    /// <remarks/>
    GMB,
    
    /// <remarks/>
    GEO,
    
    /// <remarks/>
    GHA,
    
    /// <remarks/>
    GIB,
    
    /// <remarks/>
    GRD,
    
    /// <remarks/>
    GRC,
    
    /// <remarks/>
    GRL,
    
    /// <remarks/>
    GLP,
    
    /// <remarks/>
    GUM,
    
    /// <remarks/>
    GTM,
    
    /// <remarks/>
    GUF,
    
    /// <remarks/>
    GGY,
    
    /// <remarks/>
    GIN,
    
    /// <remarks/>
    GNB,
    
    /// <remarks/>
    GNQ,
    
    /// <remarks/>
    GUY,
    
    /// <remarks/>
    HTI,
    
    /// <remarks/>
    HND,
    
    /// <remarks/>
    HKG,
    
    /// <remarks/>
    HUN,
    
    /// <remarks/>
    IND,
    
    /// <remarks/>
    IDN,
    
    /// <remarks/>
    IRQ,
    
    /// <remarks/>
    IRN,
    
    /// <remarks/>
    IRL,
    
    /// <remarks/>
    BVT,
    
    /// <remarks/>
    IMN,
    
    /// <remarks/>
    CXR,
    
    /// <remarks/>
    NFK,
    
    /// <remarks/>
    ISL,
    
    /// <remarks/>
    CYM,
    
    /// <remarks/>
    CCK,
    
    /// <remarks/>
    COK,
    
    /// <remarks/>
    FRO,
    
    /// <remarks/>
    SGS,
    
    /// <remarks/>
    HMD,
    
    /// <remarks/>
    FLK,
    
    /// <remarks/>
    MNP,
    
    /// <remarks/>
    MHL,
    
    /// <remarks/>
    PCN,
    
    /// <remarks/>
    SLB,
    
    /// <remarks/>
    TCA,
    
    /// <remarks/>
    UMI,
    
    /// <remarks/>
    VGB,
    
    /// <remarks/>
    VIR,
    
    /// <remarks/>
    ISR,
    
    /// <remarks/>
    ITA,
    
    /// <remarks/>
    JAM,
    
    /// <remarks/>
    JPN,
    
    /// <remarks/>
    JEY,
    
    /// <remarks/>
    JOR,
    
    /// <remarks/>
    KAZ,
    
    /// <remarks/>
    KEN,
    
    /// <remarks/>
    KGZ,
    
    /// <remarks/>
    KIR,
    
    /// <remarks/>
    KWT,
    
    /// <remarks/>
    LAO,
    
    /// <remarks/>
    LSO,
    
    /// <remarks/>
    LVA,
    
    /// <remarks/>
    LBN,
    
    /// <remarks/>
    LBR,
    
    /// <remarks/>
    LBY,
    
    /// <remarks/>
    LIE,
    
    /// <remarks/>
    LTU,
    
    /// <remarks/>
    LUX,
    
    /// <remarks/>
    MAC,
    
    /// <remarks/>
    MDG,
    
    /// <remarks/>
    MYS,
    
    /// <remarks/>
    MWI,
    
    /// <remarks/>
    MDV,
    
    /// <remarks/>
    MLI,
    
    /// <remarks/>
    MLT,
    
    /// <remarks/>
    MAR,
    
    /// <remarks/>
    MTQ,
    
    /// <remarks/>
    MUS,
    
    /// <remarks/>
    MRT,
    
    /// <remarks/>
    MYT,
    
    /// <remarks/>
    MEX,
    
    /// <remarks/>
    FSM,
    
    /// <remarks/>
    MDA,
    
    /// <remarks/>
    MCO,
    
    /// <remarks/>
    MNG,
    
    /// <remarks/>
    MNE,
    
    /// <remarks/>
    MSR,
    
    /// <remarks/>
    MOZ,
    
    /// <remarks/>
    NAM,
    
    /// <remarks/>
    NRU,
    
    /// <remarks/>
    NPL,
    
    /// <remarks/>
    NIC,
    
    /// <remarks/>
    NER,
    
    /// <remarks/>
    NGA,
    
    /// <remarks/>
    NIU,
    
    /// <remarks/>
    NOR,
    
    /// <remarks/>
    NCL,
    
    /// <remarks/>
    NZL,
    
    /// <remarks/>
    OMN,
    
    /// <remarks/>
    NLD,
    
    /// <remarks/>
    PAK,
    
    /// <remarks/>
    PLW,
    
    /// <remarks/>
    PSE,
    
    /// <remarks/>
    PAN,
    
    /// <remarks/>
    PNG,
    
    /// <remarks/>
    PRY,
    
    /// <remarks/>
    PER,
    
    /// <remarks/>
    PYF,
    
    /// <remarks/>
    POL,
    
    /// <remarks/>
    PRT,
    
    /// <remarks/>
    PRI,
    
    /// <remarks/>
    GBR,
    
    /// <remarks/>
    CAF,
    
    /// <remarks/>
    CZE,
    
    /// <remarks/>
    MKD,
    
    /// <remarks/>
    COG,
    
    /// <remarks/>
    COD,
    
    /// <remarks/>
    DOM,
    
    /// <remarks/>
    REU,
    
    /// <remarks/>
    RWA,
    
    /// <remarks/>
    ROU,
    
    /// <remarks/>
    RUS,
    
    /// <remarks/>
    ESH,
    
    /// <remarks/>
    WSM,
    
    /// <remarks/>
    ASM,
    
    /// <remarks/>
    BLM,
    
    /// <remarks/>
    KNA,
    
    /// <remarks/>
    SMR,
    
    /// <remarks/>
    MAF,
    
    /// <remarks/>
    SPM,
    
    /// <remarks/>
    VCT,
    
    /// <remarks/>
    SHN,
    
    /// <remarks/>
    LCA,
    
    /// <remarks/>
    STP,
    
    /// <remarks/>
    SEN,
    
    /// <remarks/>
    SRB,
    
    /// <remarks/>
    SYC,
    
    /// <remarks/>
    SLE,
    
    /// <remarks/>
    SGP,
    
    /// <remarks/>
    SXM,
    
    /// <remarks/>
    SYR,
    
    /// <remarks/>
    SOM,
    
    /// <remarks/>
    LKA,
    
    /// <remarks/>
    SWZ,
    
    /// <remarks/>
    ZAF,
    
    /// <remarks/>
    SDN,
    
    /// <remarks/>
    SSD,
    
    /// <remarks/>
    SWE,
    
    /// <remarks/>
    CHE,
    
    /// <remarks/>
    SUR,
    
    /// <remarks/>
    SJM,
    
    /// <remarks/>
    THA,
    
    /// <remarks/>
    TWN,
    
    /// <remarks/>
    TZA,
    
    /// <remarks/>
    TJK,
    
    /// <remarks/>
    IOT,
    
    /// <remarks/>
    ATF,
    
    /// <remarks/>
    TLS,
    
    /// <remarks/>
    TGO,
    
    /// <remarks/>
    TKL,
    
    /// <remarks/>
    TON,
    
    /// <remarks/>
    TTO,
    
    /// <remarks/>
    TUN,
    
    /// <remarks/>
    TKM,
    
    /// <remarks/>
    TUR,
    
    /// <remarks/>
    TUV,
    
    /// <remarks/>
    UKR,
    
    /// <remarks/>
    UGA,
    
    /// <remarks/>
    URY,
    
    /// <remarks/>
    UZB,
    
    /// <remarks/>
    VUT,
    
    /// <remarks/>
    VAT,
    
    /// <remarks/>
    VEN,
    
    /// <remarks/>
    VNM,
    
    /// <remarks/>
    WLF,
    
    /// <remarks/>
    YEM,
    
    /// <remarks/>
    DJI,
    
    /// <remarks/>
    ZMB,
    
    /// <remarks/>
    ZWE,
    
    /// <remarks/>
    ZZZ,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
public enum c_UsoCFDI {
    
    /// <remarks/>
    G01,
    
    /// <remarks/>
    G02,
    
    /// <remarks/>
    G03,
    
    /// <remarks/>
    I01,
    
    /// <remarks/>
    I02,
    
    /// <remarks/>
    I03,
    
    /// <remarks/>
    I04,
    
    /// <remarks/>
    I05,
    
    /// <remarks/>
    I06,
    
    /// <remarks/>
    I07,
    
    /// <remarks/>
    I08,
    
    /// <remarks/>
    D01,
    
    /// <remarks/>
    D02,
    
    /// <remarks/>
    D03,
    
    /// <remarks/>
    D04,
    
    /// <remarks/>
    D05,
    
    /// <remarks/>
    D06,
    
    /// <remarks/>
    D07,
    
    /// <remarks/>
    D08,
    
    /// <remarks/>
    D09,
    
    /// <remarks/>
    D10,
    
    /// <remarks/>
    P01,
    
    /// <remarks/>
    S01,
    
    /// <remarks/>
    CP01,
    
    /// <remarks/>
    CN01,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteConcepto {
    
    private ComprobanteConceptoImpuestos impuestosField;
    
    private ComprobanteConceptoACuentaTerceros aCuentaTercerosField;
    
    private ComprobanteConceptoInformacionAduanera[] informacionAduaneraField;
    
    private ComprobanteConceptoCuentaPredial[] cuentaPredialField;
    
    private ComprobanteConceptoComplementoConcepto complementoConceptoField;
    
    private ComprobanteConceptoParte[] parteField;
    
    private string claveProdServField;
    
    private string noIdentificacionField;
    
    private decimal cantidadField;
    
    private string claveUnidadField;
    
    private string unidadField;
    
    private string descripcionField;
    
    private decimal valorUnitarioField;
    
    private decimal importeField;
    
    private decimal descuentoField;
    
    private bool descuentoFieldSpecified;
    
    private c_ObjetoImp objetoImpField;
    
    /// <remarks/>
    public ComprobanteConceptoImpuestos Impuestos {
        get {
            return this.impuestosField;
        }
        set {
            this.impuestosField = value;
        }
    }
    
    /// <remarks/>
    public ComprobanteConceptoACuentaTerceros ACuentaTerceros {
        get {
            return this.aCuentaTercerosField;
        }
        set {
            this.aCuentaTercerosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InformacionAduanera")]
    public ComprobanteConceptoInformacionAduanera[] InformacionAduanera {
        get {
            return this.informacionAduaneraField;
        }
        set {
            this.informacionAduaneraField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CuentaPredial")]
    public ComprobanteConceptoCuentaPredial[] CuentaPredial {
        get {
            return this.cuentaPredialField;
        }
        set {
            this.cuentaPredialField = value;
        }
    }
    
    /// <remarks/>
    public ComprobanteConceptoComplementoConcepto ComplementoConcepto {
        get {
            return this.complementoConceptoField;
        }
        set {
            this.complementoConceptoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Parte")]
    public ComprobanteConceptoParte[] Parte {
        get {
            return this.parteField;
        }
        set {
            this.parteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ClaveProdServ {
        get {
            return this.claveProdServField;
        }
        set {
            this.claveProdServField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NoIdentificacion {
        get {
            return this.noIdentificacionField;
        }
        set {
            this.noIdentificacionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Cantidad {
        get {
            return this.cantidadField;
        }
        set {
            this.cantidadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ClaveUnidad {
        get {
            return this.claveUnidadField;
        }
        set {
            this.claveUnidadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Unidad {
        get {
            return this.unidadField;
        }
        set {
            this.unidadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Descripcion {
        get {
            return this.descripcionField;
        }
        set {
            this.descripcionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ValorUnitario {
        get {
            return this.valorUnitarioField;
        }
        set {
            this.valorUnitarioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Importe {
        get {
            return this.importeField;
        }
        set {
            this.importeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Descuento {
        get {
            return this.descuentoField;
        }
        set {
            this.descuentoField = value;
        }
    }
    
    /// <remarks/>
    /*[System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DescuentoSpecified {
        get {
            return this.descuentoFieldSpecified;
        }
        set {
            this.descuentoFieldSpecified = value;
        }
    }*/
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_ObjetoImp ObjetoImp {
        get {
            return this.objetoImpField;
        }
        set {
            this.objetoImpField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteConceptoImpuestos {
    
    private ComprobanteConceptoImpuestosTraslado[] trasladosField;
    
    private ComprobanteConceptoImpuestosRetencion[] retencionesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Traslado", IsNullable=false)]
    public ComprobanteConceptoImpuestosTraslado[] Traslados {
        get {
            return this.trasladosField;
        }
        set {
            this.trasladosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Retencion", IsNullable=false)]
    public ComprobanteConceptoImpuestosRetencion[] Retenciones {
        get {
            return this.retencionesField;
        }
        set {
            this.retencionesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteConceptoImpuestosTraslado {
    
    private decimal baseField;
    
    private string impuestoField;
    
    private c_TipoFactor tipoFactorField;
    
    private decimal tasaOCuotaField;
    
    private bool tasaOCuotaFieldSpecified;
    
    private decimal importeField;
    
    private bool importeFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Base {
        get {
            return this.baseField;
        }
        set {
            this.baseField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Impuesto {
        get {
            return this.impuestoField;
        }
        set {
            this.impuestoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_TipoFactor TipoFactor {
        get {
            return this.tipoFactorField;
        }
        set {
            this.tipoFactorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TasaOCuota {
        get {
            return this.tasaOCuotaField;
        }
        set {
            this.tasaOCuotaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TasaOCuotaSpecified {
        get {
            return this.tasaOCuotaFieldSpecified;
        }
        set {
            this.tasaOCuotaFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Importe {
        get {
            return this.importeField;
        }
        set {
            this.importeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ImporteSpecified {
        get {
            return this.importeFieldSpecified;
        }
        set {
            this.importeFieldSpecified = value;
        }
    }
}




/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteConceptoImpuestosRetencion {
    
    private decimal baseField;
    
    private string impuestoField;
    
    private c_TipoFactor tipoFactorField;
    
    private decimal tasaOCuotaField;
    
    private decimal importeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Base {
        get {
            return this.baseField;
        }
        set {
            this.baseField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Impuesto {
        get {
            return this.impuestoField;
        }
        set {
            this.impuestoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_TipoFactor TipoFactor {
        get {
            return this.tipoFactorField;
        }
        set {
            this.tipoFactorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TasaOCuota {
        get {
            return this.tasaOCuotaField;
        }
        set {
            this.tasaOCuotaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Importe {
        get {
            return this.importeField;
        }
        set {
            this.importeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteConceptoACuentaTerceros {
    
    private string rfcACuentaTercerosField;
    
    private string nombreACuentaTercerosField;
    
    private c_RegimenFiscal regimenFiscalACuentaTercerosField;
    
    private string domicilioFiscalACuentaTercerosField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RfcACuentaTerceros {
        get {
            return this.rfcACuentaTercerosField;
        }
        set {
            this.rfcACuentaTercerosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NombreACuentaTerceros {
        get {
            return this.nombreACuentaTercerosField;
        }
        set {
            this.nombreACuentaTercerosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_RegimenFiscal RegimenFiscalACuentaTerceros {
        get {
            return this.regimenFiscalACuentaTercerosField;
        }
        set {
            this.regimenFiscalACuentaTercerosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DomicilioFiscalACuentaTerceros {
        get {
            return this.domicilioFiscalACuentaTercerosField;
        }
        set {
            this.domicilioFiscalACuentaTercerosField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteConceptoInformacionAduanera {
    
    private string numeroPedimentoField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NumeroPedimento {
        get {
            return this.numeroPedimentoField;
        }
        set {
            this.numeroPedimentoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteConceptoCuentaPredial {
    
    private string numeroField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Numero {
        get {
            return this.numeroField;
        }
        set {
            this.numeroField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteConceptoComplementoConcepto {
    
    private System.Xml.XmlElement[] anyField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteConceptoParte {
    
    private ComprobanteConceptoParteInformacionAduanera[] informacionAduaneraField;
    
    private string claveProdServField;
    
    private string noIdentificacionField;
    
    private decimal cantidadField;
    
    private string unidadField;
    
    private string descripcionField;
    
    private decimal valorUnitarioField;
    
    private bool valorUnitarioFieldSpecified;
    
    private decimal importeField;
    
    private bool importeFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InformacionAduanera")]
    public ComprobanteConceptoParteInformacionAduanera[] InformacionAduanera {
        get {
            return this.informacionAduaneraField;
        }
        set {
            this.informacionAduaneraField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ClaveProdServ {
        get {
            return this.claveProdServField;
        }
        set {
            this.claveProdServField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NoIdentificacion {
        get {
            return this.noIdentificacionField;
        }
        set {
            this.noIdentificacionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Cantidad {
        get {
            return this.cantidadField;
        }
        set {
            this.cantidadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Unidad {
        get {
            return this.unidadField;
        }
        set {
            this.unidadField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Descripcion {
        get {
            return this.descripcionField;
        }
        set {
            this.descripcionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal ValorUnitario {
        get {
            return this.valorUnitarioField;
        }
        set {
            this.valorUnitarioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ValorUnitarioSpecified {
        get {
            return this.valorUnitarioFieldSpecified;
        }
        set {
            this.valorUnitarioFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Importe {
        get {
            return this.importeField;
        }
        set {
            this.importeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ImporteSpecified {
        get {
            return this.importeFieldSpecified;
        }
        set {
            this.importeFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteConceptoParteInformacionAduanera {
    
    private string numeroPedimentoField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string NumeroPedimento {
        get {
            return this.numeroPedimentoField;
        }
        set {
            this.numeroPedimentoField = value;
        }
    }
}

   
  
    
    
    
    
   
   
  

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.sat.gob.mx/sitio_internet/cfd/catalogos")]
public enum c_ObjetoImp {

    /// <remarks/>
    [DescriptionAttribute("01-No objeto de impuesto")]
    [System.Xml.Serialization.XmlEnumAttribute("01")]
    Item01,

    [DescriptionAttribute("02-S� objeto de impuesto")]
    [System.Xml.Serialization.XmlEnumAttribute("02")]
    Item02,

    [DescriptionAttribute("03-S� objeto del impuesto y no obligado al desglose")]
    [System.Xml.Serialization.XmlEnumAttribute("03")]
    Item03,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteImpuestos {
    
    private ComprobanteImpuestosRetencion[] retencionesField;
    
    private ComprobanteImpuestosTraslado[] trasladosField;
    
    private decimal totalImpuestosRetenidosField;
    
    private bool totalImpuestosRetenidosFieldSpecified;
    
    private decimal totalImpuestosTrasladadosField;
    
    private bool totalImpuestosTrasladadosFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Retencion", IsNullable=false)]
    public ComprobanteImpuestosRetencion[] Retenciones {
        get {
            return this.retencionesField;
        }
        set {
            this.retencionesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Traslado", IsNullable=false)]
    public ComprobanteImpuestosTraslado[] Traslados {
        get {
            return this.trasladosField;
        }
        set {
            this.trasladosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TotalImpuestosRetenidos {
        get {
            return this.totalImpuestosRetenidosField;
        }
        set {
            this.totalImpuestosRetenidosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TotalImpuestosRetenidosSpecified {
        get {
            return this.totalImpuestosRetenidosFieldSpecified;
        }
        set {
            this.totalImpuestosRetenidosFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TotalImpuestosTrasladados {
        get {
            return this.totalImpuestosTrasladadosField;
        }
        set {
            this.totalImpuestosTrasladadosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TotalImpuestosTrasladadosSpecified {
        get {
            return this.totalImpuestosTrasladadosFieldSpecified;
        }
        set {
            this.totalImpuestosTrasladadosFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteImpuestosRetencion {
    
    private string impuestoField;
    
    private decimal importeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Impuesto {
        get {
            return this.impuestoField;
        }
        set {
            this.impuestoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Importe {
        get {
            return this.importeField;
        }
        set {
            this.importeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteImpuestosTraslado {
    
    private decimal baseField;
    
    private string impuestoField;
    
    private c_TipoFactor tipoFactorField;
    
    private decimal tasaOCuotaField;
    
    private bool tasaOCuotaFieldSpecified;
    
    private decimal importeField;
    
    private bool importeFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Base {
        get {
            return this.baseField;
        }
        set {
            this.baseField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Impuesto {
        get {
            return this.impuestoField;
        }
        set {
            this.impuestoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public c_TipoFactor TipoFactor {
        get {
            return this.tipoFactorField;
        }
        set {
            this.tipoFactorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TasaOCuota {
        get {
            return this.tasaOCuotaField;
        }
        set {
            this.tasaOCuotaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TasaOCuotaSpecified {
        get {
            return this.tasaOCuotaFieldSpecified;
        }
        set {
            this.tasaOCuotaFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Importe {
        get {
            return this.importeField;
        }
        set {
            this.importeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ImporteSpecified {
        get {
            return this.importeFieldSpecified;
        }
        set {
            this.importeFieldSpecified = value;
        }
    }
}

/// <remarks/>
//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
//[System.SerializableAttribute()]
//[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteComplemento {
    
    private System.Xml.XmlElement[] anyField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.sat.gob.mx/cfd/4")]
public partial class ComprobanteAddenda {
    
    private System.Xml.XmlElement[] anyField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
}





