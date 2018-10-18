using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _Compi1_P2_201612331
{
    using Irony;
    using Irony.Parsing;
    using System.Globalization;

    [Language("CB", "1.0", "ChatBot Language")]
    public class Gramatica : Grammar
    {
        TerminalSet skipTokensInPreview = new TerminalSet();
        public Gramatica()
        {
            //tipos de Datos - Identificador
            IdentifierTerminal identificador = TerminalFactory.CreatePythonIdentifier("id");
            NumberLiteral number = TerminalFactory.CreateCSharpNumber("number");
            StringLiteral String = TerminalFactory.CreateCSharpString("String");
            StringLiteral Char = TerminalFactory.CreateCSharpChar("Char");

            //Comentarios
            CommentTerminal SingleLineComment = new CommentTerminal("SingleLineComment", "//", "\r", "\n", "\u2085", "\u2028", "\u2029");
            CommentTerminal DelimitedComment = new CommentTerminal("DelimitedComment", "/*", "*/");
            NonGrammarTerminals.Add(SingleLineComment);
            NonGrammarTerminals.Add(DelimitedComment);

            //Signos
            KeyTerm dPuntos = new KeyTerm(":", "DosPuntos");
            KeyTerm PComa = new KeyTerm(";", "PuntoyComa");
            KeyTerm coma = new KeyTerm(",", "coma");
            KeyTerm punto = new KeyTerm(".", "punto");
            KeyTerm CP = new KeyTerm("+", "unoOmas");
            KeyTerm CK = new KeyTerm("*", "ceroOmas");
            KeyTerm OP = new KeyTerm("?", "ceroOuno");
            KeyTerm LlaveA = ToTerm("{");
            KeyTerm LlabeB = ToTerm("}");
            KeyTerm CorA = ToTerm("[");
            KeyTerm CorB = ToTerm("]");
            KeyTerm ParA = ToTerm("(");
            KeyTerm ParB = ToTerm(")");

            //Inicio
            var Compilation_init = new NonTerminal("INICIO");
            var Compilation = new NonTerminal("COMPILACION_INICIO");
            var Compilation_List = new NonTerminal("COMPILACION_LISTA");
            var Compilations = new NonTerminal("VAR_COMPILACION");
            var bodys = new NonTerminal("CUERPO");

            var Expression = new NonTerminal("EXPRESION");
            var Expression_opt = new NonTerminal("EXPRESION_OP");
            var Expressions = new NonTerminal("EXPRESIONS");
            var PExpression = new NonTerminal("P_EXPRESION");

            //import
            /*
             * (@Paramms) Import (Identificador - Archivo) ;
             * (@Example) Import Hola.YYY;
            */

            var Import_List = new NonTerminal("IMPORT_LIST");
            var Import = new NonTerminal("IMPORT");


            //Declaracion de Variables
            /*
             * (@Paramms) (Identificador)+ : Tipo_Dato (= [Expresion])? ;
             * (@Example) nombre:String = "hola";
             * (@Example) val1,val2:int;
             */

            var Variable = new NonTerminal("VARIABLE");
            var Variable_init = new NonTerminal("VARIABLE_INIT");
            var Variable_inits = new NonTerminal("VARIABLE_INITS");
            var Argument_List = new NonTerminal("ARGUMENTOS_LIST");
            var Argument = new NonTerminal("ARGUMENTO");



            //Tipo de Datos - valor
            var Tipo = new NonTerminal("TIPO");
            var TipoMetodo = new NonTerminal("TIPO_METODO");
            var Tipos = new NonTerminal("VAR_TIPO");
            var Tipo1 = new NonTerminal("ARREGLO");
            var Valor = new NonTerminal("VALOR");
            var Asignacion = new NonTerminal("ASIGNACION");

            var Normal = new NonTerminal("DATO");
            var Compare = new NonTerminal("COMPARACION");
            var Operacion = new NonTerminal("OPERACION");

            var Valor1 = new NonTerminal("VALOR_ARREGLO");
            var ValorA = new NonTerminal("VALOR_LISTA");
            var ValorList = new NonTerminal("VALOR_S");
            var OperadoresA = new NonTerminal("OPERADORES_ARITMETICOS");
            var OperadoresR = new NonTerminal("OPERADORES_RELACIONALES");
            var OperadoresL = new NonTerminal("OPERADORES_LOGICOS");
            var Operadores = new NonTerminal("OPERADOR");
            var OperadoresD = new NonTerminal("OPERADORES_INC_DEC");

            //METODOS_LLAMADAS
            var MetodCall = new NonTerminal("LLAMADA_B");
            var ParamsMetod = new NonTerminal("PARAMETROS_B");
            var ParamsList = new NonTerminal("LISTA_PARAMETROS");
            var Param = new NonTerminal("PARAMETRO");

            //METODOS_FUNCIONES

            var Metod = new NonTerminal("METODO");

            var block = new NonTerminal("BLOCK_LIST");
            var block_body = new NonTerminal("BLOCK");
            var block_I = new NonTerminal("BLOCK_ITERADORES");
            var block_Ibody = new NonTerminal("BLOCK_ITERADORES_CUERPO");


            var Method_Params = new NonTerminal("L_PARAMETROS");
            var method_Pa = new NonTerminal("PARAMETRO");

            var method_body = new NonTerminal("METODO_CUERPO");


            //SENTENCIAS
            var Sentencia_if = new NonTerminal("SENTENCIA_IF");
            var Clause_else = new NonTerminal("CLAUSULA_ELSE");
            var Sentencia_for = new NonTerminal("SENTENCIA_FOR");
            var Sentencia_While = new NonTerminal("SENTENCIA_WHILE");
            var Sentencia_do = new NonTerminal("SENTENCIA_DO");
            var Clause_While = new NonTerminal("CLAUSULA_WHILE");
            var Sentencia_switch = new NonTerminal("SENTENCIA_SWITCH");
            var ListCase = new NonTerminal("LISTA_CASOS");
            var Case_switch = new NonTerminal("CLAUSULA_CASO");
            var Caso_Switch = new NonTerminal("CASO");
            var Default_switch = new NonTerminal("CLAUSULA_DEFAULT");
            var Sentencia_Print = new NonTerminal("SENTENCIA_PRINT");
            var For_OP = new NonTerminal("INICIO_FOR");
            var For_va = new NonTerminal("REGLA_FOR");
            var for_dec = new NonTerminal("ACCION_FOR");
            var Sentencia_Return = new NonTerminal("SENTENCIA_RETURN");




            //Precedencia de Operadores
            RegisterOperators(1, "+", "-");
            RegisterOperators(2, "*", "/", "%");
            RegisterOperators(3, "^");
            RegisterOperators(5, "==", "!=", "<", ">", "<=", ">=");
            RegisterOperators(6, "||");
            RegisterOperators(7, "=|&");
            RegisterOperators(8, "&&");
            RegisterOperators(9, "|");
            RegisterOperators(-3, "=");

            Delimiters = "{}[](),:;+-*/%&|^!~<>=";
            MarkPunctuation(";", ",", "(", ")", "{", "}", "[", "]", ":");
            MarkTransient(Expression, Compilation_init, Argument, Tipo, Valor);
            AddTermsReportGroup("ASIGNACION", "=");
            AddTermsReportGroup("TIPO", "Boolean", "String", "Char", "Int", "Double");
            AddTermsReportGroup("OPERADORES", "+", "-", "!", "~");
            AddTermsReportGroup("CONSTANTES", number, String, Char);
            AddTermsReportGroup("CONSTANTES", "true", "false", "null");
            AddToNoReportGroup("++", "--", "{", "}", "[");
            AddToNoReportGroup(coma, PComa);

            this.Root = Compilation_init;
            Compilation_init.Rule = Compilation;
            Compilation.Rule = Import_List + Compilation_List;// + (LIST_BODY) -> Metod_List | Funcion_List;
            Compilation_List.Rule = MakePlusRule(Compilation_List, null, Compilations);
            Compilations.Rule = Variable | bodys;

            //Expresiones
            Expressions.Rule = MakePlusRule(Expressions, coma, Expression);
            Expression.Rule = Normal | Operacion | Compare | PExpression;
            Normal.Rule = identificador | number | String | Char | "true" | "false" | MetodCall;
            Compare.Rule = identificador + punto + "CompareTo" + ParA + Normal + ParB;
            Operacion.Rule = Expression + Operadores + Expression;
            PExpression.Rule = ParA + Expression + ParB;
            Expression_opt.Rule = Empty | Expressions;


            //import List
            Import_List.Rule = MakeStarRule(Import_List, null, Import);

            Import.Rule = Empty | "Import" + identificador + punto + identificador + PComa;
            Import.ErrorRule = SyntaxError + PComa;

            //OPERADORES
            OperadoresA.Rule = ToTerm("+") | "-" | "*" | "/" | "^" | "%";
            OperadoresL.Rule = ToTerm("&&") | "||" | "!" | "|&";
            OperadoresR.Rule = ToTerm("==") | "!=" | "<" | ">" | ">=" | "<=";
            OperadoresD.Rule = ToTerm("--") | "++";

            //variables


            Variable.Rule = Empty | Variable_inits;
            Variable_inits.Rule = MakePlusRule(Variable_inits, coma, Variable_init);
            Variable_init.Rule = identificador + dPuntos + Tipos + PComa;

            Tipos.Rule = Tipo + Valor | Tipo1 + Valor1;
            Tipo.Rule = ToTerm("String") | "Double" | "Int" | "Char" | "Boolean" | "Void";
            Tipo1.Rule = Tipo + CorA + Argument_List + CorB;
            Valor.Rule = Empty | Asignacion + Expression;
            Asignacion.Rule = ToTerm("=");
            Valor1.Rule = Empty | Asignacion + identificador | Asignacion + ValorA;
            ValorA.Rule = CorA + ValorList + CorB;
            ValorList.Rule = MakePlusRule(ValorList, coma, Expression);

            Argument_List.Rule = MakePlusRule(Argument_List, Operadores, Argument);
            Operadores.Rule = OperadoresA | OperadoresR | OperadoresL;
            Argument.Rule = Expression | MetodCall;

            MetodCall.Rule = identificador + ParamsMetod;
            ParamsMetod.Rule = ParA + ParamsList + ParB;
            ParamsList.Rule = MakePlusRule(ParamsList, coma, Param);
            Param.Rule = Empty | Expression;
            //COmpilacion Cuerpo

            bodys.Rule = Metod;
            bodys.ErrorRule = SyntaxError + PComa | SyntaxError + LlabeB;


            //metodos

            Metod.Rule = method_body;
            Metod.ErrorRule = SyntaxError + Eof | SyntaxError;

            method_body.Rule = identificador + dPuntos + Tipo + ParA + Method_Params + ParB + LlaveA + block + Sentencia_Return + LlabeB;
            method_body.ErrorRule = SyntaxError + LlabeB | SyntaxError + PComa;

            Method_Params.Rule = MakePlusRule(Method_Params, coma, method_Pa);
            method_Pa.Rule = Empty | identificador + dPuntos + Tipo;
            block.Rule = MakeStarRule(block, null, block_body);
            block_body.Rule = Empty | Sentencia_if | Sentencia_for | Sentencia_do | Sentencia_switch | Sentencia_While | Sentencia_Return | Variable | Sentencia_Print | MetodCall;
            block_I.Rule = MakePlusRule(block_I, null, block_Ibody);
            block_Ibody.Rule = Empty | Sentencia_if | Sentencia_for | Sentencia_do | Sentencia_switch | Sentencia_While | Variable | "Break" + PComa | Sentencia_Return | Sentencia_Print | MetodCall;
            Sentencia_if.Rule = "if" + PExpression + LlaveA + block + LlabeB + Clause_else;
            Clause_else.Rule = Empty | "else" + LlaveA + block + LlabeB;
            Sentencia_for.Rule = "for" + ParA + For_OP + PComa + For_va + PComa + for_dec + ParB + LlaveA + block_I + LlabeB;
            Sentencia_do.Rule = "Do" + LlaveA + block_I + LlabeB + "While" + PExpression + PComa;
            Sentencia_While.Rule = "While" + PExpression + LlaveA + block_I + LlabeB;
            Sentencia_switch.Rule = "Switch" + ParA + Normal + ParB + LlaveA + ListCase + Default_switch + LlabeB; //Implementar List_Case
            ListCase.Rule = MakePlusRule(ListCase, null, Case_switch);
            Case_switch.Rule = Caso_Switch;
            Default_switch.Rule = Empty | "Default" + dPuntos + block_I;
            Caso_Switch.Rule = "Case" + Normal + dPuntos + block_I;

            For_OP.Rule = identificador + dPuntos + Tipo + Valor;
            For_va.Rule = Expression;
            for_dec.Rule = identificador + OperadoresD;
            Sentencia_Print.Rule = "Print" + ParA + Expression + ParB + PComa;
            Sentencia_Return.Rule = Empty | "Return" + Expression + PComa;


            skipTokensInPreview.UnionWith(new Terminal[] { punto, identificador, coma });
            LanguageFlags = LanguageFlags.NewLineBeforeEOF;
        }
        public override void ReportParseError(ParsingContext context)
        {
            base.ReportParseError(context);
        }
        public override string ConstructParserErrorMessage(ParsingContext context, StringSet expectedTerms)
        {
            return base.ConstructParserErrorMessage(context, expectedTerms);
        }
        public override void SkipWhitespace(ISourceStream source)
        {
            while (!source.EOF())
            {
                var ch = source.PreviewChar;
                switch (ch)
                {
                    case ' ':
                    case '\t':
                    case '\r':
                    case '\n':
                    case '\v':
                    case '\u2085':
                    case '\u2028':
                    case '\u2029':
                        source.PreviewPosition++;
                        break;
                    default:
                        UnicodeCategory chCat = char.GetUnicodeCategory(ch);
                        if (chCat == UnicodeCategory.SpaceSeparator)
                            continue;
                        return;
                }

            }

        }





    }
}