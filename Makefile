.RECIPEPREFIX = >
name := Libraries.Imaging.dll 
thisdir := .
cmd_library := -t:library
cmd_out := -out:$(name)
cmd_compiler := dmcs
sources := *.cs 
libs := -r:System.Data.dll -r:System.Drawing.dll -r:System.Windows.Forms.dll -r:Libraries.Collections.dll
lib_dir := -lib:../Collections/
build: $(sources)
> dmcs -unsafe -optimize $(lib_dir) $(libs) $(cmd_library) $(cmd_out) $(sources)
debug:
> dmcs -unsafe -debug $(lib_dir) $(libs) $(cmd_library) $(cmd_out) $(sources)
.PHONY : clean
clean: 
> -rm -f *.dll *.mdb
